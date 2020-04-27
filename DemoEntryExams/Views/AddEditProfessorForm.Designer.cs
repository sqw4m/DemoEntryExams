namespace DemoEntryExams.Views
{
    partial class AddEditProfessorForm
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
            this.nudPayment = new System.Windows.Forms.NumericUpDown();
            this.txbPatronymic = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPayment
            // 
            this.nudPayment.Location = new System.Drawing.Point(253, 162);
            this.nudPayment.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudPayment.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPayment.Name = "nudPayment";
            this.nudPayment.Size = new System.Drawing.Size(120, 20);
            this.nudPayment.TabIndex = 19;
            this.nudPayment.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txbPatronymic
            // 
            this.txbPatronymic.Location = new System.Drawing.Point(195, 118);
            this.txbPatronymic.Name = "txbPatronymic";
            this.txbPatronymic.Size = new System.Drawing.Size(178, 20);
            this.txbPatronymic.TabIndex = 18;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(195, 74);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(178, 20);
            this.txbName.TabIndex = 17;
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(195, 30);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(178, 20);
            this.txbSurname.TabIndex = 16;
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatronymic.Location = new System.Drawing.Point(45, 121);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(71, 16);
            this.lblPatronymic.TabIndex = 15;
            this.lblPatronymic.Text = "Отчество";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(45, 164);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(109, 16);
            this.lblPayment.TabIndex = 14;
            this.lblPayment.Text = "Размер оплаты";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(45, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Имя";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(45, 33);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(67, 16);
            this.lblSurname.TabIndex = 12;
            this.lblSurname.Text = "Фамилия";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(259, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Location = new System.Drawing.Point(39, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddEditProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 284);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudPayment);
            this.Controls.Add(this.txbPatronymic);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.MaximumSize = new System.Drawing.Size(435, 322);
            this.MinimumSize = new System.Drawing.Size(435, 322);
            this.Name = "AddEditProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPayment;
        private System.Windows.Forms.TextBox txbPatronymic;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}