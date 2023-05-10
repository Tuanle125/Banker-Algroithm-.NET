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
            this.TB_totalProcess = new System.Windows.Forms.TextBox();
            this.TB_totalResourceType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_continue = new System.Windows.Forms.Button();
            this.dataGridView_Max = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_Allocation = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Need = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Allocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Need)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banker\'s Algorithm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_continue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_totalResourceType);
            this.groupBox1.Controls.Add(this.TB_totalProcess);
            this.groupBox1.Location = new System.Drawing.Point(27, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // TB_totalProcess
            // 
            this.TB_totalProcess.Location = new System.Drawing.Point(132, 19);
            this.TB_totalProcess.Name = "TB_totalProcess";
            this.TB_totalProcess.Size = new System.Drawing.Size(97, 20);
            this.TB_totalProcess.TabIndex = 0;
            // 
            // TB_totalResourceType
            // 
            this.TB_totalResourceType.Location = new System.Drawing.Point(132, 46);
            this.TB_totalResourceType.Name = "TB_totalResourceType";
            this.TB_totalResourceType.Size = new System.Drawing.Size(97, 20);
            this.TB_totalResourceType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Processes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Resource Types";
            // 
            // BT_continue
            // 
            this.BT_continue.Location = new System.Drawing.Point(155, 71);
            this.BT_continue.Name = "BT_continue";
            this.BT_continue.Size = new System.Drawing.Size(74, 23);
            this.BT_continue.TabIndex = 4;
            this.BT_continue.Text = "Create";
            this.BT_continue.UseVisualStyleBackColor = true;
            this.BT_continue.Click += new System.EventHandler(this.BT_continue_Click);
            // 
            // dataGridView_Max
            // 
            this.dataGridView_Max.AllowUserToAddRows = false;
            this.dataGridView_Max.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Max.Location = new System.Drawing.Point(293, 97);
            this.dataGridView_Max.Name = "dataGridView_Max";
            this.dataGridView_Max.Size = new System.Drawing.Size(336, 150);
            this.dataGridView_Max.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Allocation";
            // 
            // dataGridView_Allocation
            // 
            this.dataGridView_Allocation.AllowUserToAddRows = false;
            this.dataGridView_Allocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Allocation.Location = new System.Drawing.Point(661, 97);
            this.dataGridView_Allocation.Name = "dataGridView_Allocation";
            this.dataGridView_Allocation.Size = new System.Drawing.Size(336, 150);
            this.dataGridView_Allocation.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Need";
            // 
            // dataGridView_Need
            // 
            this.dataGridView_Need.AllowUserToAddRows = false;
            this.dataGridView_Need.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Need.Location = new System.Drawing.Point(296, 339);
            this.dataGridView_Need.Name = "dataGridView_Need";
            this.dataGridView_Need.Size = new System.Drawing.Size(336, 150);
            this.dataGridView_Need.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Output";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 576);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_continue;
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
    }
}

