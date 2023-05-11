namespace Deadlock___Banker
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_Create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_totalResourceType = new System.Windows.Forms.TextBox();
            this.TB_totalProcess = new System.Windows.Forms.TextBox();
            this.dataGridView_Max = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_Allocation = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Need = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.dataGridView_Available = new System.Windows.Forms.DataGridView();
            this.BT_Update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Allocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Need)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Available)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banker\'s Algorithm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_Create);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_totalResourceType);
            this.groupBox1.Controls.Add(this.TB_totalProcess);
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // BT_Create
            // 
            this.BT_Create.Location = new System.Drawing.Point(242, 79);
            this.BT_Create.Name = "BT_Create";
            this.BT_Create.Size = new System.Drawing.Size(74, 23);
            this.BT_Create.TabIndex = 4;
            this.BT_Create.Text = "Create";
            this.BT_Create.UseVisualStyleBackColor = true;
            this.BT_Create.Click += new System.EventHandler(this.BT_Create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Resource Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Processes";
            // 
            // TB_totalResourceType
            // 
            this.TB_totalResourceType.Location = new System.Drawing.Point(219, 53);
            this.TB_totalResourceType.Name = "TB_totalResourceType";
            this.TB_totalResourceType.Size = new System.Drawing.Size(97, 20);
            this.TB_totalResourceType.TabIndex = 1;
            // 
            // TB_totalProcess
            // 
            this.TB_totalProcess.Location = new System.Drawing.Point(219, 27);
            this.TB_totalProcess.Name = "TB_totalProcess";
            this.TB_totalProcess.Size = new System.Drawing.Size(97, 20);
            this.TB_totalProcess.TabIndex = 0;
            // 
            // dataGridView_Max
            // 
            this.dataGridView_Max.AllowUserToAddRows = false;
            this.dataGridView_Max.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Max.Location = new System.Drawing.Point(25, 176);
            this.dataGridView_Max.Name = "dataGridView_Max";
            this.dataGridView_Max.Size = new System.Drawing.Size(336, 133);
            this.dataGridView_Max.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Allocation";
            // 
            // dataGridView_Allocation
            // 
            this.dataGridView_Allocation.AllowUserToAddRows = false;
            this.dataGridView_Allocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Allocation.Location = new System.Drawing.Point(393, 176);
            this.dataGridView_Allocation.Name = "dataGridView_Allocation";
            this.dataGridView_Allocation.Size = new System.Drawing.Size(336, 133);
            this.dataGridView_Allocation.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Need";
            // 
            // dataGridView_Need
            // 
            this.dataGridView_Need.AllowUserToAddRows = false;
            this.dataGridView_Need.AllowUserToDeleteRows = false;
            this.dataGridView_Need.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Need.Location = new System.Drawing.Point(25, 360);
            this.dataGridView_Need.Name = "dataGridView_Need";
            this.dataGridView_Need.ReadOnly = true;
            this.dataGridView_Need.Size = new System.Drawing.Size(336, 133);
            this.dataGridView_Need.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Output";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(832, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_Output
            // 
            this.TB_Output.Location = new System.Drawing.Point(393, 360);
            this.TB_Output.Multiline = true;
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.Size = new System.Drawing.Size(336, 133);
            this.TB_Output.TabIndex = 10;
            // 
            // dataGridView_Available
            // 
            this.dataGridView_Available.AllowUserToAddRows = false;
            this.dataGridView_Available.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Available.Location = new System.Drawing.Point(756, 176);
            this.dataGridView_Available.Name = "dataGridView_Available";
            this.dataGridView_Available.Size = new System.Drawing.Size(151, 133);
            this.dataGridView_Available.TabIndex = 11;
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(832, 325);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 12;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(753, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Available";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(765, 361);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(765, 385);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(765, 473);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 550);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.dataGridView_Available);
            this.Controls.Add(this.TB_Output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_Need);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_Allocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_Max);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Allocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Need)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Available)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_Create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_totalResourceType;
        private System.Windows.Forms.TextBox TB_totalProcess;
        private System.Windows.Forms.DataGridView dataGridView_Max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_Allocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_Need;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.DataGridView dataGridView_Available;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

