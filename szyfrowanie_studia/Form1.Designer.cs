
namespace szyfrowanie_studia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.open_bt = new System.Windows.Forms.Button();
            this.results_lb = new System.Windows.Forms.Label();
            this.save_bt = new System.Windows.Forms.Button();
            this.openFile_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.results_tb = new System.Windows.Forms.TextBox();
            this.enc_bt = new System.Windows.Forms.Button();
            this.code1_rb = new System.Windows.Forms.RadioButton();
            this.code2_rb = new System.Windows.Forms.RadioButton();
            this.clear_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open_bt
            // 
            this.open_bt.Location = new System.Drawing.Point(301, 153);
            this.open_bt.Name = "open_bt";
            this.open_bt.Size = new System.Drawing.Size(111, 38);
            this.open_bt.TabIndex = 0;
            this.open_bt.Text = "Open File";
            this.open_bt.UseVisualStyleBackColor = true;
            this.open_bt.Click += new System.EventHandler(this.open_bt_Click);
            // 
            // results_lb
            // 
            this.results_lb.AutoSize = true;
            this.results_lb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.results_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.results_lb.Location = new System.Drawing.Point(263, 497);
            this.results_lb.Name = "results_lb";
            this.results_lb.Size = new System.Drawing.Size(0, 24);
            this.results_lb.TabIndex = 1;
            // 
            // save_bt
            // 
            this.save_bt.Enabled = false;
            this.save_bt.Location = new System.Drawing.Point(301, 241);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(111, 38);
            this.save_bt.TabIndex = 4;
            this.save_bt.Text = "Save File";
            this.save_bt.UseVisualStyleBackColor = true;
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // openFile_tb
            // 
            this.openFile_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openFile_tb.Enabled = false;
            this.openFile_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile_tb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openFile_tb.Location = new System.Drawing.Point(12, 40);
            this.openFile_tb.Multiline = true;
            this.openFile_tb.Name = "openFile_tb";
            this.openFile_tb.ReadOnly = true;
            this.openFile_tb.Size = new System.Drawing.Size(283, 454);
            this.openFile_tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Open File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Results:";
            // 
            // results_tb
            // 
            this.results_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.results_tb.Enabled = false;
            this.results_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_tb.Location = new System.Drawing.Point(418, 40);
            this.results_tb.Multiline = true;
            this.results_tb.Name = "results_tb";
            this.results_tb.ReadOnly = true;
            this.results_tb.Size = new System.Drawing.Size(287, 454);
            this.results_tb.TabIndex = 7;
            // 
            // enc_bt
            // 
            this.enc_bt.Enabled = false;
            this.enc_bt.Location = new System.Drawing.Point(301, 197);
            this.enc_bt.Name = "enc_bt";
            this.enc_bt.Size = new System.Drawing.Size(111, 38);
            this.enc_bt.TabIndex = 9;
            this.enc_bt.Text = "Encrypt";
            this.enc_bt.UseVisualStyleBackColor = true;
            this.enc_bt.Click += new System.EventHandler(this.enc_bt_Click);
            // 
            // code1_rb
            // 
            this.code1_rb.AutoSize = true;
            this.code1_rb.Checked = true;
            this.code1_rb.Location = new System.Drawing.Point(330, 341);
            this.code1_rb.Name = "code1_rb";
            this.code1_rb.Size = new System.Drawing.Size(47, 17);
            this.code1_rb.TabIndex = 10;
            this.code1_rb.TabStop = true;
            this.code1_rb.Text = "RSA";
            this.code1_rb.UseVisualStyleBackColor = true;
            this.code1_rb.CheckedChanged += new System.EventHandler(this.code1_rb_CheckedChanged);
            // 
            // code2_rb
            // 
            this.code2_rb.AutoSize = true;
            this.code2_rb.Location = new System.Drawing.Point(330, 364);
            this.code2_rb.Name = "code2_rb";
            this.code2_rb.Size = new System.Drawing.Size(46, 17);
            this.code2_rb.TabIndex = 11;
            this.code2_rb.Text = "AES";
            this.code2_rb.UseVisualStyleBackColor = true;
            this.code2_rb.CheckedChanged += new System.EventHandler(this.code2_rb_CheckedChanged);
            // 
            // clear_bt
            // 
            this.clear_bt.Enabled = false;
            this.clear_bt.Location = new System.Drawing.Point(301, 285);
            this.clear_bt.Name = "clear_bt";
            this.clear_bt.Size = new System.Drawing.Size(111, 38);
            this.clear_bt.TabIndex = 12;
            this.clear_bt.Text = "Clear";
            this.clear_bt.UseVisualStyleBackColor = true;
            this.clear_bt.Click += new System.EventHandler(this.clear_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(717, 555);
            this.Controls.Add(this.clear_bt);
            this.Controls.Add(this.code2_rb);
            this.Controls.Add(this.code1_rb);
            this.Controls.Add(this.enc_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.results_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFile_tb);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.results_lb);
            this.Controls.Add(this.open_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Szyfrator2000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_bt;
        private System.Windows.Forms.Label results_lb;
        private System.Windows.Forms.Button save_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox results_tb;
        private System.Windows.Forms.TextBox openFile_tb;
        private System.Windows.Forms.Button enc_bt;
        private System.Windows.Forms.RadioButton code1_rb;
        private System.Windows.Forms.RadioButton code2_rb;
        private System.Windows.Forms.Button clear_bt;
    }
}

