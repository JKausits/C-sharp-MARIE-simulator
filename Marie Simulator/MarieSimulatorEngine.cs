using System;
using System.Windows.Forms;

namespace Marie_Simulator
{
    public class MarieSimulatorEngine {
        private DataGridView instructions;
        public int ProgramCounter { get; private set; }
        public int Accumulator { get; private set; }
        public int InstructionRegister { get; private set; }
        public int MemoryAddressRegister { get; set; }
        public int MemoryBufferRegister { get; set; }
        public int[] MemoryTable;

        public event EventHandler<string> OutputHadler;

        public event Action UpdateValues;

        public bool IsHalted { get; private set; }

        public int startInstruction { get; set; }
        public MarieSimulatorEngine(DataGridView instructions)
        {
            this.instructions = instructions;
            ProgramCounter = int.Parse(instructions.Rows[0].Cells[0].Value.ToString(), System.Globalization.NumberStyles.HexNumber);

            startInstruction = int.Parse(instructions.Rows[0].Cells[0].Value.ToString(), System.Globalization.NumberStyles.HexNumber);
            Accumulator = 0;
            IsHalted = false;
        }

        

        public void Step() {
            if (ProgramCounter < (instructions.RowCount - 1) + startInstruction && !IsHalted) {
                selectInstruction();
                handleOpcode(getInstruction());
                UpdateValues();
            }
        }

        private void handleOpcode(Opcode opcode) {

            switch (opcode) {
                // Arithmetic
                case Opcode.ADD:
                    add();
                    break;
                case Opcode.ADDI:
                    addi();
                    break;
                case Opcode.SUBT:
                    subt();
                    break;
                case Opcode.CLEAR:
                    clear();
                    break;
                // Data Transfer
                case Opcode.LOAD:
                    load();
                    break;
                case Opcode.STORE:
                    store();
                    break;
                // I/O
                case Opcode.OUTPUT:
                    Output();
                    break;
                case Opcode.INPUT:
                    // TODO
                    break;

                // Branch
                case Opcode.JUMP:
                    jump();
                    break;
                case Opcode.SKIPCOND:
                    skipcond();
                    break;

                // Subroutine
                case Opcode.JNS:
                    jns();
                    break;
                case Opcode.JUMPI:
                    jumpi();
                    break;

                // Indirect Accessing
                case Opcode.LOADI:
                    loadi();
                    break;
                case Opcode.STOREI:
                    // TODO
                    storei();
                    break;
                
                // ==================
                case Opcode.HALT:
                    halt();
                    break;
                
                
                
                
            }
        }

        


        // =================ARITHMETIC==================

        private void add()
        {
            MemoryAddressRegister = getOperand();
            MemoryBufferRegister = getSymbolValue();
            Accumulator += MemoryBufferRegister;
            ProgramCounter++;
        }

        private void addi()
        {
            MemoryAddressRegister = getOperand();
            MemoryBufferRegister = getSymbolValue();
            MemoryAddressRegister = MemoryBufferRegister;
            MemoryBufferRegister = getSymbolValue();
            Accumulator += MemoryBufferRegister;
            ProgramCounter++;
        }

        private void subt()
        {
            MemoryAddressRegister = getOperand();
            MemoryBufferRegister = getSymbolValue();
            Accumulator -= MemoryBufferRegister;
            ProgramCounter++;
        }

        private void clear()
        {
            Accumulator = 0;
            MemoryAddressRegister = ProgramCounter;
            ProgramCounter++;
        }


        // =================DATA TRANSFER==================

        private void load()
        {
            MemoryAddressRegister = getOperand();
            MemoryBufferRegister = getSymbolValue();
            Accumulator = MemoryBufferRegister;
            ProgramCounter++;
        }

        private void store()
        {
            MemoryAddressRegister = getOperand();
            MemoryBufferRegister = Accumulator;
            storeSymbol();
            ProgramCounter++;
        }


        // =================I/O==================

        private void Output()
        {
            MemoryAddressRegister = ProgramCounter;
            ProgramCounter++;
            OutputHadler?.Invoke(this, Accumulator.ToString("X4"));

        }


        // =================BRANCH==================

        private void jump()
        {
            ProgramCounter = getOperand();
        }

        private void skipcond()
        {
            var C = getOperand();
            if (C == 0)
            {
                handleSkip(Accumulator < 0);
            }
            else if (C == getHexValue("400"))
            {
                handleSkip(Accumulator == 0);
            }
            else if (C == getHexValue("800")) {
                handleSkip(Accumulator > 0);
            }
        }


        // =================SUBROUTINE==================

        private void jns()
        {
            MemoryAddressRegister = getOperand();
            MemoryBufferRegister = ProgramCounter + 1;
            storeSymbol();
            Accumulator = getOperand() + 1;
            ProgramCounter = Accumulator;
        }

        private void jumpi()
        {
            MemoryAddressRegister = getOperand();
            MemoryBufferRegister = getSymbolValue();
            MemoryAddressRegister = MemoryBufferRegister;
            MemoryBufferRegister = getSymbolValue();
            ProgramCounter = MemoryBufferRegister;
        }


        // =================INDIRECT ACCESS==================

        private void storei()
        {
            MemoryAddressRegister = getOperand();
            MemoryBufferRegister = getSymbolValue();
            MemoryAddressRegister = MemoryBufferRegister;
            storeSymbol();
            ProgramCounter++;
        }

        private void loadi()
        {
            MemoryAddressRegister = getOperand();
            MemoryBufferRegister = getSymbolValue();
            MemoryAddressRegister = MemoryBufferRegister;
            MemoryBufferRegister = getSymbolValue();
            Accumulator = MemoryBufferRegister;
            ProgramCounter++;
        }


        // ===================================================

        private void halt() {
            IsHalted = true;
            ProgramCounter++;
        }


        // =================HELPER FUNCTIONS==================

        private void selectRow(DataGridViewRow row) {
            instructions.ClearSelection();
            row.Selected = true;
        }

        private int getSymbolValue(int index) {
            //var row = instructions.Rows[index];
            //return instructions.Rows[index].Cells[4].Value.ToString();
            return MemoryTable[index];
        }

        private int getSymbolValue() {
            //MessageBox.Show(MemoryAddressRegister.ToString());
            return getSymbolValue(MemoryAddressRegister);
        }

        private int getRowIndex(int memoryAddress)
        {
            int row = 0;
            while (row < instructions.RowCount - 1) {
                //MessageBox.Show(instructions.Rows[row].Cells[0].Value.ToString() + "==" + memoryAddress.ToString("X3"));
                if (instructions.Rows[row].Cells[0].Value.ToString() == memoryAddress.ToString("X3")) {
                    return row;
                }
                row++;
            }
            return -1;
        }

        private int getHexValue(string number) {
            return int.Parse(number, System.Globalization.NumberStyles.HexNumber);
        }

        private int getOperand() {
            return getHexValue(InstructionRegister.ToString("X4").Substring(1)); 
        }

        private void storeSymbol() {
            var row = instructions.Rows[getRowIndex(MemoryAddressRegister)];
            if (row.Cells[2].Value.ToString().Equals("DEC"))
            {
                row.Cells[3].Value = MemoryBufferRegister.ToString();
                
            }
            else
            {
                row.Cells[3].Value = MemoryBufferRegister.ToString("X");
            }
            MemoryTable[MemoryAddressRegister] = MemoryBufferRegister;
            row.Cells[4].Value = MemoryBufferRegister;
        }

        private Opcode getInstruction() {
            return (Opcode)getHexValue(InstructionRegister.ToString("X4").Substring(0, 1));
        }

        private void selectInstruction() {
            var row = instructions.Rows[ProgramCounter - startInstruction];
            selectRow(row);
            
            InstructionRegister = MemoryTable[ProgramCounter];
            //MessageBox.Show("Program Counter: " + ProgramCounter + "\nInstruction Register: " + InstructionRegister);

        }

        private void handleSkip(bool isSkip) {
            if (isSkip)
            {
                ProgramCounter += 2;
            }
            else
            {
                ProgramCounter++;
            }
        }
    }
}
