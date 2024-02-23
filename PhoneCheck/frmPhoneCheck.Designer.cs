namespace PhoneCheck
{
    partial class frmPhoneCheck
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadInfo = new Button();
            groupBox1 = new GroupBox();
            txtImei2 = new TextBox();
            label6 = new Label();
            txtImei = new TextBox();
            label1 = new Label();
            txtSerialNumber = new TextBox();
            label5 = new Label();
            txtModelNumber = new TextBox();
            label4 = new Label();
            txtOSVersion = new TextBox();
            label3 = new Label();
            txtDeviceName = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            btnPair = new Button();
            groupBox2 = new GroupBox();
            txtTotalDataCapacity = new TextBox();
            label10 = new Label();
            txtPhotoUsage = new TextBox();
            label11 = new Label();
            txtTotalMemory = new TextBox();
            label12 = new Label();
            groupBox3 = new GroupBox();
            txtCurrentCapacity = new TextBox();
            label8 = new Label();
            txtCycleCount = new TextBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadInfo
            // 
            btnLoadInfo.Location = new Point(104, 33);
            btnLoadInfo.Name = "btnLoadInfo";
            btnLoadInfo.Size = new Size(75, 23);
            btnLoadInfo.TabIndex = 0;
            btnLoadInfo.Text = "Check";
            btnLoadInfo.UseVisualStyleBackColor = true;
            btnLoadInfo.Click += BtnLoadInfo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtImei2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtImei);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSerialNumber);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtModelNumber);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtOSVersion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDeviceName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(27, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 282);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // txtImei2
            // 
            txtImei2.Location = new Point(112, 221);
            txtImei2.Name = "txtImei2";
            txtImei2.Size = new Size(236, 23);
            txtImei2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 224);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 10;
            label6.Text = "IMEI2";
            // 
            // txtImei
            // 
            txtImei.Location = new Point(112, 184);
            txtImei.Name = "txtImei";
            txtImei.Size = new Size(236, 23);
            txtImei.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 187);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 8;
            label1.Text = "IMEI";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(112, 147);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(236, 23);
            txtSerialNumber.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 150);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Serial #";
            // 
            // txtModelNumber
            // 
            txtModelNumber.Location = new Point(112, 110);
            txtModelNumber.Name = "txtModelNumber";
            txtModelNumber.Size = new Size(236, 23);
            txtModelNumber.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 113);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Model #";
            // 
            // txtOSVersion
            // 
            txtOSVersion.Location = new Point(112, 73);
            txtOSVersion.Name = "txtOSVersion";
            txtOSVersion.Size = new Size(236, 23);
            txtOSVersion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 76);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "OS Version";
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new Point(112, 36);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new Size(236, 23);
            txtDeviceName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 39);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 0;
            label2.Text = "Device Name";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(185, 33);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPair
            // 
            btnPair.Location = new Point(23, 33);
            btnPair.Name = "btnPair";
            btnPair.Size = new Size(75, 23);
            btnPair.TabIndex = 5;
            btnPair.Text = "Pair";
            btnPair.UseVisualStyleBackColor = true;
            btnPair.Click += btnPair_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotalDataCapacity);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtPhotoUsage);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtTotalMemory);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(416, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 155);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Disk";
            // 
            // txtTotalDataCapacity
            // 
            txtTotalDataCapacity.Location = new Point(119, 110);
            txtTotalDataCapacity.Name = "txtTotalDataCapacity";
            txtTotalDataCapacity.Size = new Size(236, 23);
            txtTotalDataCapacity.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 113);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 4;
            label10.Text = "Total Data Capacity";
            // 
            // txtPhotoUsage
            // 
            txtPhotoUsage.Location = new Point(119, 73);
            txtPhotoUsage.Name = "txtPhotoUsage";
            txtPhotoUsage.Size = new Size(236, 23);
            txtPhotoUsage.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 76);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 2;
            label11.Text = "Photo Usage";
            // 
            // txtTotalMemory
            // 
            txtTotalMemory.Location = new Point(119, 36);
            txtTotalMemory.Name = "txtTotalMemory";
            txtTotalMemory.Size = new Size(236, 23);
            txtTotalMemory.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 39);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 0;
            label12.Text = "Total Memory";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCurrentCapacity);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtCycleCount);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(416, 223);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(374, 121);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Battery";
            // 
            // txtCurrentCapacity
            // 
            txtCurrentCapacity.Location = new Point(119, 73);
            txtCurrentCapacity.Name = "txtCurrentCapacity";
            txtCurrentCapacity.Size = new Size(236, 23);
            txtCurrentCapacity.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 76);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 2;
            label8.Text = "Current Capacity";
            // 
            // txtCycleCount
            // 
            txtCycleCount.Location = new Point(119, 36);
            txtCycleCount.Name = "txtCycleCount";
            txtCycleCount.Size = new Size(236, 23);
            txtCycleCount.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 39);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 0;
            label9.Text = "Cycle Count";
            // 
            // frmPhoneCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 570);
            Controls.Add(btnPair);
            Controls.Add(btnClear);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLoadInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPhoneCheck";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone Check";
            Load += frmPhoneCheck_Load;
            Shown += frmPhoneCheck_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadInfo;
        private GroupBox groupBox1;
        private TextBox txtSerialNumber;
        private Label label5;
        private TextBox txtModelNumber;
        private Label label4;
        private TextBox txtOSVersion;
        private Label label3;
        private TextBox txtDeviceName;
        private Label label2;
        private TextBox txtImei2;
        private Label label6;
        private TextBox txtImei;
        private Label label1;
        private Button btnClear;
        private Button btnPair;
        private GroupBox groupBox2;
        private TextBox txtPhotoUsage;
        private Label label11;
        private TextBox txtTotalMemory;
        private Label label12;
        private GroupBox groupBox3;
        private TextBox txtCurrentCapacity;
        private Label label8;
        private TextBox txtCycleCount;
        private Label label9;
        private TextBox txtTotalDataCapacity;
        private Label label10;
    }
}
