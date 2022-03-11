namespace WFA220311
{
    partial class FrmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRJelszoEll = new System.Windows.Forms.TextBox();
            this.tbRJelszo = new System.Windows.Forms.TextBox();
            this.tbREmail = new System.Windows.Forms.TextBox();
            this.tbRFN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBej = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBejFNEmail = new System.Windows.Forms.TextBox();
            this.tbBejJelszo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 577);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbRJelszoEll);
            this.groupBox1.Controls.Add(this.tbRJelszo);
            this.groupBox1.Controls.Add(this.tbREmail);
            this.groupBox1.Controls.Add(this.tbRFN);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(515, 567);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regisztráció";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(41, 448);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(420, 58);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Regisztráció";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "jelszó újra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "jelszó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "e-mail cím:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "felhasználói név:";
            // 
            // tbRJelszoEll
            // 
            this.tbRJelszoEll.Location = new System.Drawing.Point(240, 313);
            this.tbRJelszoEll.Name = "tbRJelszoEll";
            this.tbRJelszoEll.PasswordChar = '*';
            this.tbRJelszoEll.Size = new System.Drawing.Size(221, 30);
            this.tbRJelszoEll.TabIndex = 0;
            // 
            // tbRJelszo
            // 
            this.tbRJelszo.Location = new System.Drawing.Point(240, 249);
            this.tbRJelszo.Name = "tbRJelszo";
            this.tbRJelszo.PasswordChar = '*';
            this.tbRJelszo.Size = new System.Drawing.Size(221, 30);
            this.tbRJelszo.TabIndex = 0;
            // 
            // tbREmail
            // 
            this.tbREmail.Location = new System.Drawing.Point(240, 187);
            this.tbREmail.Name = "tbREmail";
            this.tbREmail.Size = new System.Drawing.Size(221, 30);
            this.tbREmail.TabIndex = 0;
            // 
            // tbRFN
            // 
            this.tbRFN.Location = new System.Drawing.Point(240, 123);
            this.tbRFN.Name = "tbRFN";
            this.tbRFN.Size = new System.Drawing.Size(221, 30);
            this.tbRFN.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBej);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbBejFNEmail);
            this.groupBox2.Controls.Add(this.tbBejJelszo);
            this.groupBox2.Location = new System.Drawing.Point(526, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 569);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bejelentkezés";
            // 
            // btnBej
            // 
            this.btnBej.Location = new System.Drawing.Point(57, 450);
            this.btnBej.Name = "btnBej";
            this.btnBej.Size = new System.Drawing.Size(420, 58);
            this.btnBej.TabIndex = 2;
            this.btnBej.Text = "Bejelentkezés";
            this.btnBej.UseVisualStyleBackColor = true;
            this.btnBej.Click += new System.EventHandler(this.btnBej_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "fn. vagy e-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "jelszó:";
            // 
            // tbBejFNEmail
            // 
            this.tbBejFNEmail.Location = new System.Drawing.Point(221, 189);
            this.tbBejFNEmail.Name = "tbBejFNEmail";
            this.tbBejFNEmail.Size = new System.Drawing.Size(221, 30);
            this.tbBejFNEmail.TabIndex = 0;
            // 
            // tbBejJelszo
            // 
            this.tbBejJelszo.Location = new System.Drawing.Point(221, 239);
            this.tbBejJelszo.Name = "tbBejJelszo";
            this.tbBejJelszo.PasswordChar = '*';
            this.tbBejJelszo.Size = new System.Drawing.Size(221, 30);
            this.tbBejJelszo.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 610);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRJelszoEll;
        private System.Windows.Forms.TextBox tbRJelszo;
        private System.Windows.Forms.TextBox tbREmail;
        private System.Windows.Forms.TextBox tbRFN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBej;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBejFNEmail;
        private System.Windows.Forms.TextBox tbBejJelszo;
    }
}

