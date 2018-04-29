using System;
using System.Windows.Forms;

namespace Marie_Simulator
{
    public partial class MarieSimulatorForm : Form
    {   
        private MarieSimulatorEngine marieSimulatorEngine;
        private System.Windows.Forms.Timer timer1;


        public MarieSimulatorForm()
        {
            InitializeComponent();
           
            InitTimer();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "csv file (*.csv)|*.csv";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                instructionGridView.Rows.Clear();
                instructionGridView.Refresh();
                runButton.Visible = false;
                stepButton.Visible = false;
                var instructionParser = new CSVInstructionParser(openFileDialog1.FileName);//new TextInstrutionParser(openFileDialog1.FileName);
                foreach (var row in instructionParser.BuildTableRows(instructionGridView.Rows[0])) {
                    instructionGridView.Rows.Add(row);
                }
                runButton.Visible = true;
                stepButton.Visible = true;
                marieSimulatorEngine = new MarieSimulatorEngine(instructionGridView);
                marieSimulatorEngine.OutputHadler += (object source, string message) => { outputTextBox.Text += message + Environment.NewLine; };
                marieSimulatorEngine.UpdateValues += new Action(setValues);
                marieSimulatorEngine.MemoryTable = instructionParser.GetMemoryTable();
                setMemoryGridView(marieSimulatorEngine.MemoryTable);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            StopTimer();
            marieSimulatorEngine.Step();
            
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled) {
                timer1.Start();
            }

        }


        private void setMemoryGridView(int[] memoryTable)
        {
            var row = (DataGridViewRow) memoryGridView.Rows[0].Clone();
            var rowcount = 0;
            row.Cells[0].Value = rowcount.ToString("X3");
            for (int i = 0; i < memoryTable.Length; i++)
            {
                row.Cells[(i % 16) + 1].Value = memoryTable[i].ToString("X4");
                if ((i + 1) % 16 == 0) {
                    memoryGridView.Rows.Add(row);
                    row = (DataGridViewRow)memoryGridView.Rows[0].Clone();
                    rowcount += 16;
                    row.Cells[0].Value = rowcount.ToString("X3");
                }
            }
        }

        private void setValues() {
            acTextBox.Text = marieSimulatorEngine.Accumulator.ToString("X4");
            irTextBox.Text = marieSimulatorEngine.InstructionRegister.ToString("X4");
            pcTextBox.Text = marieSimulatorEngine.ProgramCounter.ToString("X3");
            marTextBox.Text = marieSimulatorEngine.MemoryAddressRegister.ToString("X3");
            mbrTextBox.Text = marieSimulatorEngine.MemoryBufferRegister.ToString("X4");
        }

        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(stepButton_Click);
            timer1.Interval = 250; // in miliseconds
            
        }

        public void StopTimer() {
            if (marieSimulatorEngine.IsHalted) {
                timer1.Stop();
                timer1.Dispose();
            }
        }
    }

}
