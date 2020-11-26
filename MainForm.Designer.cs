namespace FractalBuilder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.drawButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.assymetricalCheckBox = new System.Windows.Forms.CheckBox();
            this.trackLength = new System.Windows.Forms.TrackBar();
            this.trackLengthDivider = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.multicoloredCheckBox = new System.Windows.Forms.CheckBox();
            this.trackAngle = new System.Windows.Forms.TrackBar();
            this.labelTiltAngle = new System.Windows.Forms.Label();
            this.labelInitialLength = new System.Windows.Forms.Label();
            this.labelLengthDivider = new System.Windows.Forms.Label();
            this.closedCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLengthDivider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAngle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.drawButton.FlatAppearance.BorderSize = 0;
            this.drawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawButton.ForeColor = System.Drawing.Color.White;
            this.drawButton.Location = new System.Drawing.Point(987, 607);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 2;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.DrawButtonClick);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Fractal tree",
            "Barnsley\'s fern",
            "Quasi-clover fractal"});
            this.comboBox.Location = new System.Drawing.Point(19, 42);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(212, 21);
            this.comboBox.TabIndex = 3;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
            // 
            // assymetricalCheckBox
            // 
            this.assymetricalCheckBox.AutoSize = true;
            this.assymetricalCheckBox.Location = new System.Drawing.Point(24, 49);
            this.assymetricalCheckBox.Name = "assymetricalCheckBox";
            this.assymetricalCheckBox.Size = new System.Drawing.Size(84, 17);
            this.assymetricalCheckBox.TabIndex = 5;
            this.assymetricalCheckBox.Text = "Assymetrical";
            this.assymetricalCheckBox.UseVisualStyleBackColor = true;
            // 
            // trackLength
            // 
            this.trackLength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackLength.Location = new System.Drawing.Point(134, 46);
            this.trackLength.Maximum = 400;
            this.trackLength.Minimum = 40;
            this.trackLength.Name = "trackLength";
            this.trackLength.Size = new System.Drawing.Size(104, 45);
            this.trackLength.TabIndex = 6;
            this.trackLength.TickFrequency = 5;
            this.trackLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackLength.Value = 200;
            // 
            // trackLengthDivider
            // 
            this.trackLengthDivider.BackColor = System.Drawing.Color.White;
            this.trackLengthDivider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackLengthDivider.LargeChange = 10;
            this.trackLengthDivider.Location = new System.Drawing.Point(24, 46);
            this.trackLengthDivider.Maximum = 240;
            this.trackLengthDivider.Minimum = 140;
            this.trackLengthDivider.Name = "trackLengthDivider";
            this.trackLengthDivider.Size = new System.Drawing.Size(104, 45);
            this.trackLengthDivider.SmallChange = 10;
            this.trackLengthDivider.TabIndex = 7;
            this.trackLengthDivider.Tag = "";
            this.trackLengthDivider.TickFrequency = 20;
            this.trackLengthDivider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackLengthDivider.Value = 150;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1074, 595);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // multicoloredCheckBox
            // 
            this.multicoloredCheckBox.AutoSize = true;
            this.multicoloredCheckBox.Location = new System.Drawing.Point(24, 26);
            this.multicoloredCheckBox.Name = "multicoloredCheckBox";
            this.multicoloredCheckBox.Size = new System.Drawing.Size(83, 17);
            this.multicoloredCheckBox.TabIndex = 9;
            this.multicoloredCheckBox.Text = "Multicolored";
            this.multicoloredCheckBox.UseVisualStyleBackColor = true;
            // 
            // trackAngle
            // 
            this.trackAngle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackAngle.LargeChange = 15;
            this.trackAngle.Location = new System.Drawing.Point(244, 46);
            this.trackAngle.Maximum = 75;
            this.trackAngle.Minimum = -75;
            this.trackAngle.Name = "trackAngle";
            this.trackAngle.Size = new System.Drawing.Size(104, 45);
            this.trackAngle.SmallChange = 15;
            this.trackAngle.TabIndex = 15;
            this.trackAngle.TickFrequency = 15;
            this.trackAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // labelTiltAngle
            // 
            this.labelTiltAngle.AutoSize = true;
            this.labelTiltAngle.Location = new System.Drawing.Point(241, 30);
            this.labelTiltAngle.Name = "labelTiltAngle";
            this.labelTiltAngle.Size = new System.Drawing.Size(34, 13);
            this.labelTiltAngle.TabIndex = 11;
            this.labelTiltAngle.Text = "Angle";
            // 
            // labelInitialLength
            // 
            this.labelInitialLength.AutoSize = true;
            this.labelInitialLength.Location = new System.Drawing.Point(131, 30);
            this.labelInitialLength.Name = "labelInitialLength";
            this.labelInitialLength.Size = new System.Drawing.Size(63, 13);
            this.labelInitialLength.TabIndex = 16;
            this.labelInitialLength.Text = "Initial length";
            // 
            // labelLengthDivider
            // 
            this.labelLengthDivider.AutoSize = true;
            this.labelLengthDivider.Location = new System.Drawing.Point(21, 30);
            this.labelLengthDivider.Name = "labelLengthDivider";
            this.labelLengthDivider.Size = new System.Drawing.Size(74, 13);
            this.labelLengthDivider.TabIndex = 17;
            this.labelLengthDivider.Text = "Length divider";
            // 
            // closedCheckBox
            // 
            this.closedCheckBox.AutoSize = true;
            this.closedCheckBox.Location = new System.Drawing.Point(24, 72);
            this.closedCheckBox.Name = "closedCheckBox";
            this.closedCheckBox.Size = new System.Drawing.Size(58, 17);
            this.closedCheckBox.TabIndex = 18;
            this.closedCheckBox.Text = "Closed";
            this.closedCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLengthDivider);
            this.groupBox1.Controls.Add(this.trackLengthDivider);
            this.groupBox1.Controls.Add(this.labelInitialLength);
            this.groupBox1.Controls.Add(this.labelTiltAngle);
            this.groupBox1.Controls.Add(this.trackAngle);
            this.groupBox1.Controls.Add(this.trackLength);
            this.groupBox1.Location = new System.Drawing.Point(494, 601);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 99);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.multicoloredCheckBox);
            this.groupBox2.Controls.Add(this.assymetricalCheckBox);
            this.groupBox2.Controls.Add(this.closedCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(855, 601);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 99);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flags";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox);
            this.groupBox3.Location = new System.Drawing.Point(236, 601);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fractal type";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(987, 676);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 601);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 112);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 713);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.drawButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractal Builder 2020";
            ((System.ComponentModel.ISupportInitialize)(this.trackLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLengthDivider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAngle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.CheckBox assymetricalCheckBox;
        private System.Windows.Forms.TrackBar trackLength;
        private System.Windows.Forms.TrackBar trackLengthDivider;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox multicoloredCheckBox;
        private System.Windows.Forms.TrackBar trackAngle;
        private System.Windows.Forms.Label labelTiltAngle;
        private System.Windows.Forms.Label labelInitialLength;
        private System.Windows.Forms.Label labelLengthDivider;
        private System.Windows.Forms.CheckBox closedCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

