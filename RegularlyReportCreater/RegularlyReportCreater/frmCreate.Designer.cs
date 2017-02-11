namespace RegularlyReportCreater {
    partial class frmCreate {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImpression = new System.Windows.Forms.RichTextBox();
            this.cbxLearning1 = new System.Windows.Forms.ComboBox();
            this.cbxLearning2 = new System.Windows.Forms.ComboBox();
            this.cbxLearning3 = new System.Windows.Forms.ComboBox();
            this.cbxTask1 = new System.Windows.Forms.ComboBox();
            this.cbxTask2 = new System.Windows.Forms.ComboBox();
            this.cbxTask3 = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCacel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "報告先";
            // 
            // cbxDestination
            // 
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(102, 23);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(121, 20);
            this.cbxDestination.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "作業内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "自宅学習";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "所感";
            // 
            // txtImpression
            // 
            this.txtImpression.Location = new System.Drawing.Point(102, 336);
            this.txtImpression.Name = "txtImpression";
            this.txtImpression.Size = new System.Drawing.Size(741, 118);
            this.txtImpression.TabIndex = 5;
            this.txtImpression.Text = "";
            // 
            // cbxLearning1
            // 
            this.cbxLearning1.FormattingEnabled = true;
            this.cbxLearning1.Location = new System.Drawing.Point(102, 197);
            this.cbxLearning1.Name = "cbxLearning1";
            this.cbxLearning1.Size = new System.Drawing.Size(741, 20);
            this.cbxLearning1.TabIndex = 6;
            // 
            // cbxLearning2
            // 
            this.cbxLearning2.FormattingEnabled = true;
            this.cbxLearning2.Location = new System.Drawing.Point(102, 241);
            this.cbxLearning2.Name = "cbxLearning2";
            this.cbxLearning2.Size = new System.Drawing.Size(741, 20);
            this.cbxLearning2.TabIndex = 7;
            // 
            // cbxLearning3
            // 
            this.cbxLearning3.FormattingEnabled = true;
            this.cbxLearning3.Location = new System.Drawing.Point(102, 285);
            this.cbxLearning3.Name = "cbxLearning3";
            this.cbxLearning3.Size = new System.Drawing.Size(741, 20);
            this.cbxLearning3.TabIndex = 8;
            // 
            // cbxTask1
            // 
            this.cbxTask1.FormattingEnabled = true;
            this.cbxTask1.Location = new System.Drawing.Point(102, 66);
            this.cbxTask1.Name = "cbxTask1";
            this.cbxTask1.Size = new System.Drawing.Size(741, 20);
            this.cbxTask1.TabIndex = 9;
            // 
            // cbxTask2
            // 
            this.cbxTask2.FormattingEnabled = true;
            this.cbxTask2.Location = new System.Drawing.Point(102, 113);
            this.cbxTask2.Name = "cbxTask2";
            this.cbxTask2.Size = new System.Drawing.Size(741, 20);
            this.cbxTask2.TabIndex = 10;
            // 
            // cbxTask3
            // 
            this.cbxTask3.FormattingEnabled = true;
            this.cbxTask3.Location = new System.Drawing.Point(102, 155);
            this.cbxTask3.Name = "cbxTask3";
            this.cbxTask3.Size = new System.Drawing.Size(741, 20);
            this.cbxTask3.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(768, 476);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCacel
            // 
            this.btnCacel.Location = new System.Drawing.Point(672, 476);
            this.btnCacel.Name = "btnCacel";
            this.btnCacel.Size = new System.Drawing.Size(75, 23);
            this.btnCacel.TabIndex = 13;
            this.btnCacel.Text = "キャンセル";
            this.btnCacel.UseVisualStyleBackColor = true;
            this.btnCacel.Click += new System.EventHandler(this.btnCacel_Click);
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.btnCacel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbxTask3);
            this.Controls.Add(this.cbxTask2);
            this.Controls.Add(this.cbxTask1);
            this.Controls.Add(this.cbxLearning3);
            this.Controls.Add(this.cbxLearning2);
            this.Controls.Add(this.cbxLearning1);
            this.Controls.Add(this.txtImpression);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDestination);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "作成ダイアログ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtImpression;
        private System.Windows.Forms.ComboBox cbxLearning1;
        private System.Windows.Forms.ComboBox cbxLearning2;
        private System.Windows.Forms.ComboBox cbxLearning3;
        private System.Windows.Forms.ComboBox cbxTask1;
        private System.Windows.Forms.ComboBox cbxTask2;
        private System.Windows.Forms.ComboBox cbxTask3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCacel;
    }
}