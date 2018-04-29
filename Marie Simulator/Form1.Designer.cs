namespace Marie_Simulator
{
    partial class MarieSimulatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pcTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mbrTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.marTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.irTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.acTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.instructionGridView = new System.Windows.Forms.DataGridView();
            this.programCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.memoryGridView = new System.Windows.Forms.DataGridView();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instructionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(10, 30);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(189, 184);
            this.outputTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.outputTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(664, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 232);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(439, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(217, 232);
            this.panel2.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.inputTextBox);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(8, 188);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 30);
            this.panel8.TabIndex = 8;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputTextBox.Enabled = false;
            this.inputTextBox.Location = new System.Drawing.Point(65, 4);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Input";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pcTextBox);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(8, 152);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 30);
            this.panel7.TabIndex = 8;
            // 
            // pcTextBox
            // 
            this.pcTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pcTextBox.Enabled = false;
            this.pcTextBox.Location = new System.Drawing.Point(65, 4);
            this.pcTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pcTextBox.Name = "pcTextBox";
            this.pcTextBox.Size = new System.Drawing.Size(100, 20);
            this.pcTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "PC";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.mbrTextBox);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(8, 116);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 30);
            this.panel6.TabIndex = 8;
            // 
            // mbrTextBox
            // 
            this.mbrTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mbrTextBox.Enabled = false;
            this.mbrTextBox.Location = new System.Drawing.Point(65, 4);
            this.mbrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mbrTextBox.Name = "mbrTextBox";
            this.mbrTextBox.Size = new System.Drawing.Size(100, 20);
            this.mbrTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "MBR";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.marTextBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(8, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 30);
            this.panel5.TabIndex = 8;
            // 
            // marTextBox
            // 
            this.marTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.marTextBox.Enabled = false;
            this.marTextBox.Location = new System.Drawing.Point(65, 4);
            this.marTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.marTextBox.Name = "marTextBox";
            this.marTextBox.Size = new System.Drawing.Size(100, 20);
            this.marTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "MAR";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.irTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(8, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 30);
            this.panel4.TabIndex = 8;
            // 
            // irTextBox
            // 
            this.irTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.irTextBox.Enabled = false;
            this.irTextBox.Location = new System.Drawing.Point(65, 4);
            this.irTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.irTextBox.Name = "irTextBox";
            this.irTextBox.Size = new System.Drawing.Size(100, 20);
            this.irTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "IR";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.acTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 30);
            this.panel3.TabIndex = 7;
            // 
            // acTextBox
            // 
            this.acTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.acTextBox.Enabled = false;
            this.acTextBox.Location = new System.Drawing.Point(65, 4);
            this.acTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.acTextBox.Name = "acTextBox";
            this.acTextBox.Size = new System.Drawing.Size(100, 20);
            this.acTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "AC";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // instructionGridView
            // 
            this.instructionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instructionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programCounter,
            this.label,
            this.opcode,
            this.operand,
            this.hex});
            this.instructionGridView.Location = new System.Drawing.Point(13, 68);
            this.instructionGridView.Name = "instructionGridView";
            this.instructionGridView.RowHeadersVisible = false;
            this.instructionGridView.Size = new System.Drawing.Size(418, 232);
            this.instructionGridView.TabIndex = 7;
            // 
            // programCounter
            // 
            this.programCounter.HeaderText = "";
            this.programCounter.Name = "programCounter";
            this.programCounter.Width = 50;
            // 
            // label
            // 
            this.label.HeaderText = "Label";
            this.label.Name = "label";
            // 
            // opcode
            // 
            this.opcode.HeaderText = "Opcode";
            this.opcode.Name = "opcode";
            // 
            // operand
            // 
            this.operand.HeaderText = "Operand";
            this.operand.Name = "operand";
            // 
            // hex
            // 
            this.hex.HeaderText = "Hex";
            this.hex.Name = "hex";
            this.hex.Width = 50;
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(13, 27);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(85, 34);
            this.runButton.TabIndex = 8;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Visible = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // stepButton
            // 
            this.stepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepButton.Location = new System.Drawing.Point(104, 28);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(85, 34);
            this.stepButton.TabIndex = 9;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Visible = false;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // memoryGridView
            // 
            this.memoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row,
            this.column0,
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5,
            this.column6,
            this.column7,
            this.column8,
            this.column9,
            this.columnA,
            this.columnB,
            this.columnC,
            this.columnD,
            this.columnE,
            this.columnF});
            this.memoryGridView.Location = new System.Drawing.Point(13, 319);
            this.memoryGridView.Name = "memoryGridView";
            this.memoryGridView.RowHeadersVisible = false;
            this.memoryGridView.Size = new System.Drawing.Size(860, 230);
            this.memoryGridView.TabIndex = 10;
            // 
            // row
            // 
            this.row.HeaderText = "";
            this.row.Name = "row";
            this.row.Width = 50;
            // 
            // column0
            // 
            this.column0.HeaderText = "+0";
            this.column0.Name = "column0";
            this.column0.Width = 50;
            // 
            // column1
            // 
            this.column1.HeaderText = "+1";
            this.column1.Name = "column1";
            this.column1.Width = 50;
            // 
            // column2
            // 
            this.column2.HeaderText = "+2";
            this.column2.Name = "column2";
            this.column2.Width = 50;
            // 
            // column3
            // 
            this.column3.HeaderText = "+3";
            this.column3.Name = "column3";
            this.column3.Width = 50;
            // 
            // column4
            // 
            this.column4.HeaderText = "+4";
            this.column4.Name = "column4";
            this.column4.Width = 50;
            // 
            // column5
            // 
            this.column5.HeaderText = "+5";
            this.column5.Name = "column5";
            this.column5.Width = 50;
            // 
            // column6
            // 
            this.column6.HeaderText = "+6";
            this.column6.Name = "column6";
            this.column6.Width = 50;
            // 
            // column7
            // 
            this.column7.HeaderText = "+7";
            this.column7.Name = "column7";
            this.column7.Width = 50;
            // 
            // column8
            // 
            this.column8.HeaderText = "+8";
            this.column8.Name = "column8";
            this.column8.Width = 50;
            // 
            // column9
            // 
            this.column9.HeaderText = "+9";
            this.column9.Name = "column9";
            this.column9.Width = 50;
            // 
            // columnA
            // 
            this.columnA.HeaderText = "+A";
            this.columnA.Name = "columnA";
            this.columnA.Width = 50;
            // 
            // columnB
            // 
            this.columnB.HeaderText = "+B";
            this.columnB.Name = "columnB";
            this.columnB.Width = 50;
            // 
            // columnC
            // 
            this.columnC.HeaderText = "+C";
            this.columnC.Name = "columnC";
            this.columnC.Width = 50;
            // 
            // columnD
            // 
            this.columnD.HeaderText = "+D";
            this.columnD.Name = "columnD";
            this.columnD.Width = 50;
            // 
            // columnE
            // 
            this.columnE.HeaderText = "+E";
            this.columnE.Name = "columnE";
            this.columnE.Width = 50;
            // 
            // columnF
            // 
            this.columnF.HeaderText = "+F";
            this.columnF.Name = "columnF";
            this.columnF.Width = 50;
            // 
            // MarieSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.memoryGridView);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.instructionGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MarieSimulatorForm";
            this.Text = "Marie Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instructionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox acTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox pcTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox mbrTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox marTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox irTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView instructionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn programCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn operand;
        private System.Windows.Forms.DataGridViewTextBoxColumn hex;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.DataGridView memoryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.DataGridViewTextBoxColumn column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnE;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnF;
    }
}

