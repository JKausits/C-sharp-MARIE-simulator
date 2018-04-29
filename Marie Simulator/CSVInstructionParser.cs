using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Marie_Simulator
{
    public class CSVInstructionParser {
        public string FileName { get; private set; }
        private readonly Dictionary<string, string> symbolTable = new Dictionary<string, string>();
        private int[] memoryTable = new int[int.Parse("FFF", System.Globalization.NumberStyles.HexNumber)];
        public CSVInstructionParser(string fileName)
        {
            if (!fileName.EndsWith(".csv"))
            {
                throw new Exception("Invalid File Type");
            }
                FileName = fileName;
            
        }

        private void BuildSymbolTable() {
            symbolTable.Clear();
            using (var sr = new StreamReader(FileName)) {
                string line = sr.ReadLine();
                int counter = 0;
                while((line = sr.ReadLine()) != null)
                {
                    var lineArray = line.Split(',');
                    if (lineArray[1] == "ORG") {
                        counter = int.Parse(lineArray[2], System.Globalization.NumberStyles.HexNumber) - 1;
                    }else if (!String.IsNullOrWhiteSpace(lineArray[0])) {
                        symbolTable.Add(lineArray[0], counter.ToString("X3"));
                    }
                    counter++;

                    
                }
            }
        }

        private string buildHexValue(Opcode opcode, string operand) {
            var hasOperand = new Opcode[] { Opcode.ADD, Opcode.STORE, Opcode.LOAD, Opcode.DEC, Opcode.HEX, Opcode.ADDI, Opcode.JUMP, Opcode.SKIPCOND, Opcode.JNS, Opcode.JUMPI, Opcode.STOREI, Opcode.LOADI, Opcode.SUBT};
            if (hasOperand.Contains(opcode))
            {
                if (opcode == Opcode.DEC)
                {
                    
                    return int.Parse(operand).ToString("X4");
                }
                else if (opcode == Opcode.HEX)
                {
                    return int.Parse(operand, System.Globalization.NumberStyles.HexNumber).ToString("X4");
                }
                else if (symbolTable.ContainsKey(operand))
                {
                    return ((int)opcode).ToString("X1") + symbolTable[operand];
                }
                else {
                    return ((int)opcode).ToString("X1") + operand;
                }
            }
            else {
                return ((int)opcode).ToString("X1") + "000";
            }
        }

        public int[] GetMemoryTable() {
            return memoryTable;
        }

        public IEnumerable<DataGridViewRow> BuildTableRows(DataGridViewRow clonableRow)
        {
            BuildSymbolTable();
            using (var sr = new StreamReader(FileName))
            {
                string line = sr.ReadLine();
                int counter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    var instructionArray = line.Split(',');
                    if (instructionArray[1] == "ORG")
                    {
                        counter = int.Parse(instructionArray[2], System.Globalization.NumberStyles.HexNumber);
                    }
                    else {

                        Opcode opcode;
                        string operand = instructionArray[2];
                        Enum.TryParse<Opcode>(instructionArray[1].ToUpper(), out opcode);
                        
                        // Build Row
                        var row = (DataGridViewRow)clonableRow.Clone();
                        var hex = buildHexValue(opcode, operand);
                        row.Cells[0].Value = counter.ToString("X3");
                        row.Cells[1].Value = instructionArray[0];
                        row.Cells[2].Value = opcode.ToString();
                        row.Cells[3].Value = operand;
                        row.Cells[4].Value = hex;

                        memoryTable[counter] = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                        yield return row;
                        counter++;
                    }


                }
            }
        }

    }
}
