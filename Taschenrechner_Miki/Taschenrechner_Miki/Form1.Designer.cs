namespace Taschenrechner_Miki
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_Mal = new System.Windows.Forms.Button();
            this.button_Geteilt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Gleich = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CE
            // 
            this.button_CE.Location = new System.Drawing.Point(0, 19);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(108, 23);
            this.button_CE.TabIndex = 0;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_Plus
            // 
            this.button_Plus.Location = new System.Drawing.Point(0, 48);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(108, 23);
            this.button_Plus.TabIndex = 1;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            // 
            // button_Minus
            // 
            this.button_Minus.Location = new System.Drawing.Point(0, 77);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(108, 23);
            this.button_Minus.TabIndex = 2;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            // 
            // button_Mal
            // 
            this.button_Mal.Location = new System.Drawing.Point(0, 106);
            this.button_Mal.Name = "button_Mal";
            this.button_Mal.Size = new System.Drawing.Size(108, 23);
            this.button_Mal.TabIndex = 3;
            this.button_Mal.Text = "*";
            this.button_Mal.UseVisualStyleBackColor = true;
            // 
            // button_Geteilt
            // 
            this.button_Geteilt.Location = new System.Drawing.Point(0, 135);
            this.button_Geteilt.Name = "button_Geteilt";
            this.button_Geteilt.Size = new System.Drawing.Size(108, 23);
            this.button_Geteilt.TabIndex = 4;
            this.button_Geteilt.Text = "/";
            this.button_Geteilt.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 210);
            this.textBox1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBox1, "Zahl eingeben, anschließend Rechenoperation, anschließend nächste Zahl eingeben");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Taschenrechner";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Gleich);
            this.groupBox1.Controls.Add(this.button_CE);
            this.groupBox1.Controls.Add(this.button_Plus);
            this.groupBox1.Controls.Add(this.button_Minus);
            this.groupBox1.Controls.Add(this.button_Geteilt);
            this.groupBox1.Controls.Add(this.button_Mal);
            this.groupBox1.Location = new System.Drawing.Point(167, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechenoperationen";
            // 
            // button_Gleich
            // 
            this.button_Gleich.Location = new System.Drawing.Point(0, 164);
            this.button_Gleich.Name = "button_Gleich";
            this.button_Gleich.Size = new System.Drawing.Size(108, 23);
            this.button_Gleich.TabIndex = 5;
            this.button_Gleich.Text = "=";
            this.button_Gleich.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 259);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Mal;
        private System.Windows.Forms.Button button_Geteilt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Gleich;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

