namespace winforms_checkserial
{
    partial class Form1
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
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdCheck = new System.Windows.Forms.Button();
            this.cboSerienNummer = new System.Windows.Forms.ComboBox();
            this.LblAusgabeCheck = new System.Windows.Forms.Label();
            this.LblAusgabeRechenweg = new System.Windows.Forms.Label();
            this.LblAusgabeCboText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.RosyBrown;
            this.CmdClose.Font = new System.Drawing.Font("Tempus Sans ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdClose.ForeColor = System.Drawing.Color.Transparent;
            this.CmdClose.Location = new System.Drawing.Point(705, 181);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(91, 41);
            this.CmdClose.TabIndex = 0;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdCheck
            // 
            this.CmdCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdCheck.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdCheck.Location = new System.Drawing.Point(495, 96);
            this.CmdCheck.Name = "CmdCheck";
            this.CmdCheck.Size = new System.Drawing.Size(115, 35);
            this.CmdCheck.TabIndex = 1;
            this.CmdCheck.Text = "Check";
            this.CmdCheck.UseVisualStyleBackColor = true;
            this.CmdCheck.Click += new System.EventHandler(this.CmdCheck_Click);
            // 
            // cboSerienNummer
            // 
            this.cboSerienNummer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSerienNummer.FormattingEnabled = true;
            this.cboSerienNummer.Items.AddRange(new object[] {
            "X33119695154",
            "N23445645678",
            "R34535676677",
            "R56464656",
            "T46646325249",
            "3223442422244"});
            this.cboSerienNummer.Location = new System.Drawing.Point(173, 101);
            this.cboSerienNummer.Name = "cboSerienNummer";
            this.cboSerienNummer.Size = new System.Drawing.Size(274, 28);
            this.cboSerienNummer.TabIndex = 2;
            // 
            // LblAusgabeCheck
            // 
            this.LblAusgabeCheck.AutoSize = true;
            this.LblAusgabeCheck.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAusgabeCheck.Location = new System.Drawing.Point(627, 101);
            this.LblAusgabeCheck.Name = "LblAusgabeCheck";
            this.LblAusgabeCheck.Size = new System.Drawing.Size(0, 25);
            this.LblAusgabeCheck.TabIndex = 3;
            // 
            // LblAusgabeRechenweg
            // 
            this.LblAusgabeRechenweg.AutoSize = true;
            this.LblAusgabeRechenweg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAusgabeRechenweg.Location = new System.Drawing.Point(12, 202);
            this.LblAusgabeRechenweg.Name = "LblAusgabeRechenweg";
            this.LblAusgabeRechenweg.Size = new System.Drawing.Size(0, 20);
            this.LblAusgabeRechenweg.TabIndex = 4;
            // 
            // LblAusgabeCboText
            // 
            this.LblAusgabeCboText.AutoSize = true;
            this.LblAusgabeCboText.Location = new System.Drawing.Point(173, 78);
            this.LblAusgabeCboText.Name = "LblAusgabeCboText";
            this.LblAusgabeCboText.Size = new System.Drawing.Size(157, 17);
            this.LblAusgabeCboText.TabIndex = 5;
            this.LblAusgabeCboText.Text = "Seriennummer (Banknote)";
            this.LblAusgabeCboText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 234);
            this.Controls.Add(this.LblAusgabeCboText);
            this.Controls.Add(this.LblAusgabeRechenweg);
            this.Controls.Add(this.LblAusgabeCheck);
            this.Controls.Add(this.cboSerienNummer);
            this.Controls.Add(this.CmdCheck);
            this.Controls.Add(this.CmdClose);
            this.Name = "Form1";
            this.Text = "Aufgabe 04: WindowsForms (CheckSerial Banknote)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdClose;
        private Button CmdCheck;
        private ComboBox cboSerienNummer;
        private Label LblAusgabeCheck;
        private Label LblAusgabeRechenweg;
        private Label LblAusgabeCboText;
    }
}