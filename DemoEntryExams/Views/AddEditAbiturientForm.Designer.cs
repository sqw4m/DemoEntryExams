namespace DemoEntryExams.Views
{
    partial class AddEditAbiturientForm
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
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPatronymic = new System.Windows.Forms.TextBox();
            this.txbPassport = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.nudBithYear = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBithYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(45, 33);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(67, 16);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Фамилия";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(45, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Имя";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatronymic.Location = new System.Drawing.Point(45, 121);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(71, 16);
            this.lblPatronymic.TabIndex = 3;
            this.lblPatronymic.Text = "Отчество";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthYear.Location = new System.Drawing.Point(45, 164);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(98, 16);
            this.lblBirthYear.TabIndex = 2;
            this.lblBirthYear.Text = "Год рождения";
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassport.Location = new System.Drawing.Point(45, 209);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(64, 16);
            this.lblPassport.TabIndex = 5;
            this.lblPassport.Text = "Паспорт";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(45, 253);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 16);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Адрес";
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(195, 30);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(178, 20);
            this.txbSurname.TabIndex = 6;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(195, 74);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(178, 20);
            this.txbName.TabIndex = 7;
            // 
            // txbPatronymic
            // 
            this.txbPatronymic.Location = new System.Drawing.Point(195, 118);
            this.txbPatronymic.Name = "txbPatronymic";
            this.txbPatronymic.Size = new System.Drawing.Size(178, 20);
            this.txbPatronymic.TabIndex = 8;
            // 
            // txbPassport
            // 
            this.txbPassport.Location = new System.Drawing.Point(195, 206);
            this.txbPassport.Name = "txbPassport";
            this.txbPassport.Size = new System.Drawing.Size(178, 20);
            this.txbPassport.TabIndex = 9;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(195, 250);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(178, 20);
            this.txbAddress.TabIndex = 10;
            // 
            // nudBithYear
            // 
            this.nudBithYear.Location = new System.Drawing.Point(253, 162);
            this.nudBithYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudBithYear.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudBithYear.Name = "nudBithYear";
            this.nudBithYear.Size = new System.Drawing.Size(120, 20);
            this.nudBithYear.TabIndex = 11;
            this.nudBithYear.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Location = new System.Drawing.Point(38, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(258, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddEditAbiturientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 380);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudBithYear);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbPassport);
            this.Controls.Add(this.txbPatronymic);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.MaximumSize = new System.Drawing.Size(435, 418);
            this.MinimumSize = new System.Drawing.Size(435, 418);
            this.Name = "AddEditAbiturientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditAbiturientForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudBithYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPatronymic;
        private System.Windows.Forms.TextBox txbPassport;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.NumericUpDown nudBithYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}