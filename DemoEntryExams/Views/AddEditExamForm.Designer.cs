namespace DemoEntryExams.Views
{
    partial class AddEditExamForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblExamDate = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblAbiturient = new System.Windows.Forms.Label();
            this.cbxAbiturient = new System.Windows.Forms.ComboBox();
            this.cbxProfessor = new System.Windows.Forms.ComboBox();
            this.mcrExamDate = new System.Windows.Forms.MonthCalendar();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.nudExamGrade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(259, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Location = new System.Drawing.Point(39, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(46, 303);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(66, 16);
            this.lblSubject.TabIndex = 19;
            this.lblSubject.Text = "Предмет";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(46, 347);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(57, 16);
            this.lblGrade.TabIndex = 18;
            this.lblGrade.Text = "Оценка";
            // 
            // lblExamDate
            // 
            this.lblExamDate.AutoSize = true;
            this.lblExamDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamDate.Location = new System.Drawing.Point(46, 193);
            this.lblExamDate.Name = "lblExamDate";
            this.lblExamDate.Size = new System.Drawing.Size(40, 16);
            this.lblExamDate.TabIndex = 16;
            this.lblExamDate.Text = "Дата";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(46, 78);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(97, 16);
            this.lblProfessor.TabIndex = 15;
            this.lblProfessor.Text = "Экзаменатор";
            // 
            // lblAbiturient
            // 
            this.lblAbiturient.AutoSize = true;
            this.lblAbiturient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbiturient.Location = new System.Drawing.Point(46, 34);
            this.lblAbiturient.Name = "lblAbiturient";
            this.lblAbiturient.Size = new System.Drawing.Size(87, 16);
            this.lblAbiturient.TabIndex = 14;
            this.lblAbiturient.Text = "Абитуриент";
            // 
            // cbxAbiturient
            // 
            this.cbxAbiturient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAbiturient.FormattingEnabled = true;
            this.cbxAbiturient.Location = new System.Drawing.Point(163, 34);
            this.cbxAbiturient.Name = "cbxAbiturient";
            this.cbxAbiturient.Size = new System.Drawing.Size(211, 21);
            this.cbxAbiturient.TabIndex = 28;
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfessor.FormattingEnabled = true;
            this.cbxProfessor.Location = new System.Drawing.Point(163, 77);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(211, 21);
            this.cbxProfessor.TabIndex = 29;
            // 
            // mcrExamDate
            // 
            this.mcrExamDate.Location = new System.Drawing.Point(210, 120);
            this.mcrExamDate.Name = "mcrExamDate";
            this.mcrExamDate.TabIndex = 30;
            // 
            // cbxSubject
            // 
            this.cbxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(196, 302);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(178, 21);
            this.cbxSubject.TabIndex = 31;
            // 
            // nudExamGrade
            // 
            this.nudExamGrade.Location = new System.Drawing.Point(314, 347);
            this.nudExamGrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudExamGrade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExamGrade.Name = "nudExamGrade";
            this.nudExamGrade.Size = new System.Drawing.Size(60, 20);
            this.nudExamGrade.TabIndex = 32;
            this.nudExamGrade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddEditExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 482);
            this.Controls.Add(this.nudExamGrade);
            this.Controls.Add(this.cbxSubject);
            this.Controls.Add(this.mcrExamDate);
            this.Controls.Add(this.cbxProfessor);
            this.Controls.Add(this.cbxAbiturient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblExamDate);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.lblAbiturient);
            this.MaximumSize = new System.Drawing.Size(435, 520);
            this.MinimumSize = new System.Drawing.Size(435, 520);
            this.Name = "AddEditExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditExamForm";
            this.Load += new System.EventHandler(this.AddEditExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudExamGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblExamDate;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblAbiturient;
        private System.Windows.Forms.ComboBox cbxAbiturient;
        private System.Windows.Forms.ComboBox cbxProfessor;
        private System.Windows.Forms.MonthCalendar mcrExamDate;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.NumericUpDown nudExamGrade;
    }
}