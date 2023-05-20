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
            this.dataGridView_Allocation = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Need = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.dataGridView_Total = new System.Windows.Forms.DataGridView();
            this.BT_Update = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BT_SafeCheck = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_ResourceRequest = new System.Windows.Forms.TextBox();
            this.BT_RequestCheck = new System.Windows.Forms.Button();
            this.TB_ProcessRequest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Allocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Need)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Total)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.dataGridView_Max.AllowUserToResizeColumns = false;
            this.dataGridView_Max.AllowUserToResizeRows = false;
            this.dataGridView_Max.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Max.Location = new System.Drawing.Point(25, 176);
            this.dataGridView_Max.Name = "dataGridView_Max";
            this.dataGridView_Max.RowHeadersWidth = 51;
            this.dataGridView_Max.Size = new System.Drawing.Size(336, 133);
            this.dataGridView_Max.TabIndex = 2;
            this.dataGridView_Max.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Max_CellValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max";
            // 
            // dataGridView_Allocation
            // 
            this.dataGridView_Allocation.AllowUserToAddRows = false;
            this.dataGridView_Allocation.AllowUserToResizeColumns = false;
            this.dataGridView_Allocation.AllowUserToResizeRows = false;
            this.dataGridView_Allocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Allocation.Location = new System.Drawing.Point(393, 176);
            this.dataGridView_Allocation.Name = "dataGridView_Allocation";
            this.dataGridView_Allocation.RowHeadersWidth = 51;
            this.dataGridView_Allocation.Size = new System.Drawing.Size(336, 133);
            this.dataGridView_Allocation.TabIndex = 3;
            this.dataGridView_Allocation.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Allocation_CellValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Need";
            // 
            // dataGridView_Need
            // 
            this.dataGridView_Need.AllowUserToAddRows = false;
            this.dataGridView_Need.AllowUserToDeleteRows = false;
            this.dataGridView_Need.AllowUserToResizeColumns = false;
            this.dataGridView_Need.AllowUserToResizeRows = false;
            this.dataGridView_Need.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Need.Location = new System.Drawing.Point(25, 360);
            this.dataGridView_Need.MultiSelect = false;
            this.dataGridView_Need.Name = "dataGridView_Need";
            this.dataGridView_Need.ReadOnly = true;
            this.dataGridView_Need.RowHeadersWidth = 51;
            this.dataGridView_Need.Size = new System.Drawing.Size(336, 133);
            this.dataGridView_Need.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Output";
            // 
            // TB_Output
            // 
            this.TB_Output.Location = new System.Drawing.Point(393, 360);
            this.TB_Output.Multiline = true;
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.ReadOnly = true;
            this.TB_Output.Size = new System.Drawing.Size(336, 133);
            this.TB_Output.TabIndex = 13;
            // 
            // dataGridView_Total
            // 
            this.dataGridView_Total.AllowUserToAddRows = false;
            this.dataGridView_Total.AllowUserToResizeColumns = false;
            this.dataGridView_Total.AllowUserToResizeRows = false;
            this.dataGridView_Total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Total.Location = new System.Drawing.Point(756, 176);
            this.dataGridView_Total.Name = "dataGridView_Total";
            this.dataGridView_Total.RowHeadersWidth = 51;
            this.dataGridView_Total.Size = new System.Drawing.Size(151, 133);
            this.dataGridView_Total.TabIndex = 4;
            this.dataGridView_Total.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Total_CellValueChanged);
            // 
            // BT_Update
            // 
            this.BT_Update.Location = new System.Drawing.Point(832, 319);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(75, 23);
            this.BT_Update.TabIndex = 5;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = true;
            this.BT_Update.Click += new System.EventHandler(this.BT_Update_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(756, 360);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(151, 138);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = "";
            this.tabPage1.Controls.Add(this.BT_SafeCheck);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(143, 112);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Safe Check";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BT_SafeCheck
            // 
            this.BT_SafeCheck.Location = new System.Drawing.Point(67, 75);
            this.BT_SafeCheck.Name = "BT_SafeCheck";
            this.BT_SafeCheck.Size = new System.Drawing.Size(70, 23);
            this.BT_SafeCheck.TabIndex = 0;
            this.BT_SafeCheck.Text = "Check";
            this.BT_SafeCheck.UseVisualStyleBackColor = true;
            this.BT_SafeCheck.Click += new System.EventHandler(this.BT_SafeCheck_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.TB_ResourceRequest);
            this.tabPage2.Controls.Add(this.BT_RequestCheck);
            this.tabPage2.Controls.Add(this.TB_ProcessRequest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(143, 112);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Resources";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Process";
            // 
            // TB_ResourceRequest
            // 
            this.TB_ResourceRequest.Location = new System.Drawing.Point(64, 41);
            this.TB_ResourceRequest.Name = "TB_ResourceRequest";
            this.TB_ResourceRequest.Size = new System.Drawing.Size(73, 20);
            this.TB_ResourceRequest.TabIndex = 19;
            // 
            // BT_RequestCheck
            // 
            this.BT_RequestCheck.Location = new System.Drawing.Point(66, 77);
            this.BT_RequestCheck.Name = "BT_RequestCheck";
            this.BT_RequestCheck.Size = new System.Drawing.Size(72, 23);
            this.BT_RequestCheck.TabIndex = 20;
            this.BT_RequestCheck.Text = "Check";
            this.BT_RequestCheck.UseVisualStyleBackColor = true;
            this.BT_RequestCheck.Click += new System.EventHandler(this.BT_RequestCheck_Click);
            // 
            // TB_ProcessRequest
            // 
            this.TB_ProcessRequest.Location = new System.Drawing.Point(64, 15);
            this.TB_ProcessRequest.Name = "TB_ProcessRequest";
            this.TB_ProcessRequest.Size = new System.Drawing.Size(73, 20);
            this.TB_ProcessRequest.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Allocation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(757, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Resources";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 516);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BT_Update);
            this.Controls.Add(this.dataGridView_Total);
            this.Controls.Add(this.TB_Output);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banker\'s Algorithm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Allocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Need)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Total)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView_Allocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_Need;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.DataGridView dataGridView_Total;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BT_SafeCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_ResourceRequest;
        private System.Windows.Forms.Button BT_RequestCheck;
        private System.Windows.Forms.TextBox TB_ProcessRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}

