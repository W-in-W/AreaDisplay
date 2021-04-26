namespace AreaDisplay
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.servicesComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseDirectoryBtn = new System.Windows.Forms.Button();
            this.everyNPointBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.everyNPointBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить точки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextBox.Location = new System.Drawing.Point(171, 30);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(441, 55);
            this.AddressTextBox.TabIndex = 1;
            // 
            // servicesComboBox
            // 
            this.servicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicesComboBox.Items.AddRange(new object[] {"Nominatim"});
            this.servicesComboBox.Location = new System.Drawing.Point(171, 107);
            this.servicesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.servicesComboBox.Name = "servicesComboBox";
            this.servicesComboBox.Size = new System.Drawing.Size(131, 25);
            this.servicesComboBox.TabIndex = 3;
            this.servicesComboBox.SelectedValueChanged +=
                new System.EventHandler(this.servicesComboBox_SelectedValueChanged);
            // 
            // ChooseDirectoryBtn
            // 
            this.ChooseDirectoryBtn.Location = new System.Drawing.Point(398, 239);
            this.ChooseDirectoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseDirectoryBtn.Name = "ChooseDirectoryBtn";
            this.ChooseDirectoryBtn.Size = new System.Drawing.Size(98, 30);
            this.ChooseDirectoryBtn.TabIndex = 4;
            this.ChooseDirectoryBtn.Text = "Выбрать файл";
            this.ChooseDirectoryBtn.UseVisualStyleBackColor = true;
            this.ChooseDirectoryBtn.Click += new System.EventHandler(this.ChooseDirectoryBtn_Click);
            // 
            // everyNPointBox
            // 
            this.everyNPointBox.Font = new System.Drawing.Font("Segoe UI Semilight", 9F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.everyNPointBox.Location = new System.Drawing.Point(171, 149);
            this.everyNPointBox.Margin = new System.Windows.Forms.Padding(2);
            this.everyNPointBox.Maximum = new decimal(new int[] {999, 0, 0, 0});
            this.everyNPointBox.Name = "everyNPointBox";
            this.everyNPointBox.Size = new System.Drawing.Size(48, 27);
            this.everyNPointBox.TabIndex = 5;
            this.everyNPointBox.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Адрес для поиска:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сервис для поиска:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(39, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выбирать каждую";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(225, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "точку";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.everyNPointBox);
            this.Controls.Add(this.ChooseDirectoryBtn);
            this.Controls.Add(this.servicesComboBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 7.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AreaDisplay";
            ((System.ComponentModel.ISupportInitialize) (this.everyNPointBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button ChooseDirectoryBtn;
        private System.Windows.Forms.NumericUpDown everyNPointBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox servicesComboBox;
    }
}