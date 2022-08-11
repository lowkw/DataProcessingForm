namespace DataProcessingForm
{
    partial class DataProcessingForm
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
            this.listView = new System.Windows.Forms.ListView();
            this.columnSensorA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSensorB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxSensorA = new System.Windows.Forms.ListBox();
            this.listBoxSensorB = new System.Windows.Forms.ListBox();
            this.buttonBinSIteA = new System.Windows.Forms.Button();
            this.buttonBinSRecA = new System.Windows.Forms.Button();
            this.textBoxIteTicksA = new System.Windows.Forms.TextBox();
            this.textBoxRecTicksA = new System.Windows.Forms.TextBox();
            this.textBoxSelSortSecA = new System.Windows.Forms.TextBox();
            this.textBoxInsSortSecA = new System.Windows.Forms.TextBox();
            this.buttonSelSortA = new System.Windows.Forms.Button();
            this.buttonInsSortA = new System.Windows.Forms.Button();
            this.textBoxSearchA = new System.Windows.Forms.TextBox();
            this.buttonLoadSensorData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBinSIteB = new System.Windows.Forms.Button();
            this.textBoxIteTicksB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonBinSRecB = new System.Windows.Forms.Button();
            this.textBoxRecTicksB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearchB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSelSortB = new System.Windows.Forms.Button();
            this.textBoxSelSortSecB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonInsSortB = new System.Windows.Forms.Button();
            this.textBoxInsSortSecB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sigmaNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.muNumUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSensorA,
            this.columnSensorB});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 92);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(157, 381);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnSensorA
            // 
            this.columnSensorA.Text = "Sensor A";
            this.columnSensorA.Width = 70;
            // 
            // columnSensorB
            // 
            this.columnSensorB.Text = "Sensor B";
            this.columnSensorB.Width = 70;
            // 
            // listBoxSensorA
            // 
            this.listBoxSensorA.FormattingEnabled = true;
            this.listBoxSensorA.Location = new System.Drawing.Point(327, 93);
            this.listBoxSensorA.Name = "listBoxSensorA";
            this.listBoxSensorA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSensorA.Size = new System.Drawing.Size(126, 381);
            this.listBoxSensorA.TabIndex = 1;
            // 
            // listBoxSensorB
            // 
            this.listBoxSensorB.FormattingEnabled = true;
            this.listBoxSensorB.Location = new System.Drawing.Point(622, 92);
            this.listBoxSensorB.Name = "listBoxSensorB";
            this.listBoxSensorB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSensorB.Size = new System.Drawing.Size(129, 381);
            this.listBoxSensorB.TabIndex = 2;
            // 
            // buttonBinSIteA
            // 
            this.buttonBinSIteA.Location = new System.Drawing.Point(198, 86);
            this.buttonBinSIteA.Name = "buttonBinSIteA";
            this.buttonBinSIteA.Size = new System.Drawing.Size(100, 23);
            this.buttonBinSIteA.TabIndex = 3;
            this.buttonBinSIteA.Text = "Search";
            this.buttonBinSIteA.UseVisualStyleBackColor = true;
            this.buttonBinSIteA.Click += new System.EventHandler(this.buttonBinSIteA_Click);
            // 
            // buttonBinSRecA
            // 
            this.buttonBinSRecA.Location = new System.Drawing.Point(198, 170);
            this.buttonBinSRecA.Name = "buttonBinSRecA";
            this.buttonBinSRecA.Size = new System.Drawing.Size(100, 23);
            this.buttonBinSRecA.TabIndex = 4;
            this.buttonBinSRecA.Text = "Search";
            this.buttonBinSRecA.UseVisualStyleBackColor = true;
            this.buttonBinSRecA.Click += new System.EventHandler(this.buttonBinSRecA_Click);
            // 
            // textBoxIteTicksA
            // 
            this.textBoxIteTicksA.Location = new System.Drawing.Point(198, 115);
            this.textBoxIteTicksA.Name = "textBoxIteTicksA";
            this.textBoxIteTicksA.ReadOnly = true;
            this.textBoxIteTicksA.Size = new System.Drawing.Size(100, 20);
            this.textBoxIteTicksA.TabIndex = 5;
            // 
            // textBoxRecTicksA
            // 
            this.textBoxRecTicksA.Location = new System.Drawing.Point(200, 202);
            this.textBoxRecTicksA.Name = "textBoxRecTicksA";
            this.textBoxRecTicksA.ReadOnly = true;
            this.textBoxRecTicksA.Size = new System.Drawing.Size(98, 20);
            this.textBoxRecTicksA.TabIndex = 6;
            // 
            // textBoxSelSortSecA
            // 
            this.textBoxSelSortSecA.Location = new System.Drawing.Point(200, 337);
            this.textBoxSelSortSecA.Name = "textBoxSelSortSecA";
            this.textBoxSelSortSecA.ReadOnly = true;
            this.textBoxSelSortSecA.Size = new System.Drawing.Size(98, 20);
            this.textBoxSelSortSecA.TabIndex = 7;
            // 
            // textBoxInsSortSecA
            // 
            this.textBoxInsSortSecA.Location = new System.Drawing.Point(200, 426);
            this.textBoxInsSortSecA.Name = "textBoxInsSortSecA";
            this.textBoxInsSortSecA.ReadOnly = true;
            this.textBoxInsSortSecA.Size = new System.Drawing.Size(98, 20);
            this.textBoxInsSortSecA.TabIndex = 8;
            // 
            // buttonSelSortA
            // 
            this.buttonSelSortA.Location = new System.Drawing.Point(200, 308);
            this.buttonSelSortA.Name = "buttonSelSortA";
            this.buttonSelSortA.Size = new System.Drawing.Size(98, 23);
            this.buttonSelSortA.TabIndex = 9;
            this.buttonSelSortA.Text = "Sort";
            this.buttonSelSortA.UseVisualStyleBackColor = true;
            this.buttonSelSortA.Click += new System.EventHandler(this.buttonSelSortA_Click);
            // 
            // buttonInsSortA
            // 
            this.buttonInsSortA.Location = new System.Drawing.Point(200, 397);
            this.buttonInsSortA.Name = "buttonInsSortA";
            this.buttonInsSortA.Size = new System.Drawing.Size(98, 23);
            this.buttonInsSortA.TabIndex = 10;
            this.buttonInsSortA.Text = "Sort";
            this.buttonInsSortA.UseVisualStyleBackColor = true;
            this.buttonInsSortA.Click += new System.EventHandler(this.buttonInsSortA_Click);
            // 
            // textBoxSearchA
            // 
            this.textBoxSearchA.Location = new System.Drawing.Point(250, 246);
            this.textBoxSearchA.Name = "textBoxSearchA";
            this.textBoxSearchA.Size = new System.Drawing.Size(43, 20);
            this.textBoxSearchA.TabIndex = 11;
            this.textBoxSearchA.TextChanged += new System.EventHandler(this.textBoxSearchA_TextChanged);
            // 
            // buttonLoadSensorData
            // 
            this.buttonLoadSensorData.Location = new System.Drawing.Point(12, 63);
            this.buttonLoadSensorData.Name = "buttonLoadSensorData";
            this.buttonLoadSensorData.Size = new System.Drawing.Size(157, 23);
            this.buttonLoadSensorData.TabIndex = 12;
            this.buttonLoadSensorData.Text = "Load Sensor Data";
            this.buttonLoadSensorData.UseVisualStyleBackColor = true;
            this.buttonLoadSensorData.Click += new System.EventHandler(this.buttonLoadSensorData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sensor A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Binary Search Iterative";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Binary Search Recursive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Search \r\nTarget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Selection Sort";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Insertion Sort";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Binary Search Iterative";
            // 
            // buttonBinSIteB
            // 
            this.buttonBinSIteB.Location = new System.Drawing.Point(494, 86);
            this.buttonBinSIteB.Name = "buttonBinSIteB";
            this.buttonBinSIteB.Size = new System.Drawing.Size(100, 23);
            this.buttonBinSIteB.TabIndex = 23;
            this.buttonBinSIteB.Text = "Search";
            this.buttonBinSIteB.UseVisualStyleBackColor = true;
            this.buttonBinSIteB.Click += new System.EventHandler(this.buttonBinSIteB_Click);
            // 
            // textBoxIteTicksB
            // 
            this.textBoxIteTicksB.Location = new System.Drawing.Point(494, 115);
            this.textBoxIteTicksB.Name = "textBoxIteTicksB";
            this.textBoxIteTicksB.ReadOnly = true;
            this.textBoxIteTicksB.Size = new System.Drawing.Size(100, 20);
            this.textBoxIteTicksB.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Binary Search Recursive";
            // 
            // buttonBinSRecB
            // 
            this.buttonBinSRecB.Location = new System.Drawing.Point(495, 170);
            this.buttonBinSRecB.Name = "buttonBinSRecB";
            this.buttonBinSRecB.Size = new System.Drawing.Size(99, 23);
            this.buttonBinSRecB.TabIndex = 26;
            this.buttonBinSRecB.Text = "Search";
            this.buttonBinSRecB.UseVisualStyleBackColor = true;
            this.buttonBinSRecB.Click += new System.EventHandler(this.buttonBinSRecB_Click);
            // 
            // textBoxRecTicksB
            // 
            this.textBoxRecTicksB.Location = new System.Drawing.Point(495, 202);
            this.textBoxRecTicksB.Name = "textBoxRecTicksB";
            this.textBoxRecTicksB.ReadOnly = true;
            this.textBoxRecTicksB.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecTicksB.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(492, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Search \r\nTarget";
            // 
            // textBoxSearchB
            // 
            this.textBoxSearchB.Location = new System.Drawing.Point(542, 246);
            this.textBoxSearchB.Name = "textBoxSearchB";
            this.textBoxSearchB.Size = new System.Drawing.Size(43, 20);
            this.textBoxSearchB.TabIndex = 29;
            this.textBoxSearchB.TextChanged += new System.EventHandler(this.textBoxSearchB_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(492, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Selection Sort";
            // 
            // buttonSelSortB
            // 
            this.buttonSelSortB.Location = new System.Drawing.Point(495, 305);
            this.buttonSelSortB.Name = "buttonSelSortB";
            this.buttonSelSortB.Size = new System.Drawing.Size(99, 23);
            this.buttonSelSortB.TabIndex = 31;
            this.buttonSelSortB.Text = "Sort";
            this.buttonSelSortB.UseVisualStyleBackColor = true;
            this.buttonSelSortB.Click += new System.EventHandler(this.buttonSelSortB_Click);
            // 
            // textBoxSelSortSecB
            // 
            this.textBoxSelSortSecB.Location = new System.Drawing.Point(495, 337);
            this.textBoxSelSortSecB.Name = "textBoxSelSortSecB";
            this.textBoxSelSortSecB.ReadOnly = true;
            this.textBoxSelSortSecB.Size = new System.Drawing.Size(99, 20);
            this.textBoxSelSortSecB.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(496, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Insertion Sort";
            // 
            // buttonInsSortB
            // 
            this.buttonInsSortB.Location = new System.Drawing.Point(495, 397);
            this.buttonInsSortB.Name = "buttonInsSortB";
            this.buttonInsSortB.Size = new System.Drawing.Size(99, 23);
            this.buttonInsSortB.TabIndex = 34;
            this.buttonInsSortB.Text = "Sort";
            this.buttonInsSortB.UseVisualStyleBackColor = true;
            this.buttonInsSortB.Click += new System.EventHandler(this.buttonInsSortB_Click);
            // 
            // textBoxInsSortSecB
            // 
            this.textBoxInsSortSecB.Location = new System.Drawing.Point(494, 426);
            this.textBoxInsSortSecB.Name = "textBoxInsSortSecB";
            this.textBoxInsSortSecB.ReadOnly = true;
            this.textBoxInsSortSecB.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsSortSecB.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Sigma";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Mu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(489, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Sensor B";
            // 
            // sigmaNumUpDown
            // 
            this.sigmaNumUpDown.Location = new System.Drawing.Point(23, 29);
            this.sigmaNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.sigmaNumUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sigmaNumUpDown.Name = "sigmaNumUpDown";
            this.sigmaNumUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sigmaNumUpDown.Size = new System.Drawing.Size(47, 20);
            this.sigmaNumUpDown.TabIndex = 39;
            this.sigmaNumUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // muNumUpDown
            // 
            this.muNumUpDown.Location = new System.Drawing.Point(94, 29);
            this.muNumUpDown.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.muNumUpDown.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.muNumUpDown.Name = "muNumUpDown";
            this.muNumUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.muNumUpDown.Size = new System.Drawing.Size(51, 20);
            this.muNumUpDown.TabIndex = 40;
            this.muNumUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.muNumUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // DataProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 486);
            this.Controls.Add(this.muNumUpDown);
            this.Controls.Add(this.sigmaNumUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxInsSortSecB);
            this.Controls.Add(this.buttonInsSortB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxSelSortSecB);
            this.Controls.Add(this.buttonSelSortB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxSearchB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRecTicksB);
            this.Controls.Add(this.buttonBinSRecB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxIteTicksB);
            this.Controls.Add(this.buttonBinSIteB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoadSensorData);
            this.Controls.Add(this.textBoxSearchA);
            this.Controls.Add(this.buttonInsSortA);
            this.Controls.Add(this.buttonSelSortA);
            this.Controls.Add(this.textBoxInsSortSecA);
            this.Controls.Add(this.textBoxSelSortSecA);
            this.Controls.Add(this.textBoxRecTicksA);
            this.Controls.Add(this.textBoxIteTicksA);
            this.Controls.Add(this.buttonBinSRecA);
            this.Controls.Add(this.buttonBinSIteA);
            this.Controls.Add(this.listBoxSensorB);
            this.Controls.Add(this.listBoxSensorA);
            this.Controls.Add(this.listView);
            this.Name = "DataProcessingForm";
            this.Text = "Data Processing";
            this.Load += new System.EventHandler(this.DataProcessingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sigmaNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ListBox listBoxSensorA;
        private System.Windows.Forms.ListBox listBoxSensorB;
        private System.Windows.Forms.Button buttonBinSIteA;
        private System.Windows.Forms.Button buttonBinSRecA;
        private System.Windows.Forms.TextBox textBoxIteTicksA;
        private System.Windows.Forms.TextBox textBoxRecTicksA;
        private System.Windows.Forms.TextBox textBoxSelSortSecA;
        private System.Windows.Forms.TextBox textBoxInsSortSecA;
        private System.Windows.Forms.Button buttonSelSortA;
        private System.Windows.Forms.Button buttonInsSortA;
        private System.Windows.Forms.TextBox textBoxSearchA;
        private System.Windows.Forms.Button buttonLoadSensorData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBinSIteB;
        private System.Windows.Forms.ColumnHeader columnSensorA;
        private System.Windows.Forms.ColumnHeader columnSensorB;
        private System.Windows.Forms.TextBox textBoxIteTicksB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonBinSRecB;
        private System.Windows.Forms.TextBox textBoxRecTicksB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSearchB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSelSortB;
        private System.Windows.Forms.TextBox textBoxSelSortSecB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonInsSortB;
        private System.Windows.Forms.TextBox textBoxInsSortSecB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown sigmaNumUpDown;
        private System.Windows.Forms.NumericUpDown muNumUpDown;
    }
}

