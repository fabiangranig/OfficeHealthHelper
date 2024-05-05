namespace OfficeHealthHelper
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
            this.label_Timer = new System.Windows.Forms.Label();
            this.label_Bodyposition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Location = new System.Drawing.Point(12, 9);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(96, 16);
            this.label_Timer.TabIndex = 0;
            this.label_Timer.Text = "<empty Timer>";
            // 
            // label_Bodyposition
            // 
            this.label_Bodyposition.AutoSize = true;
            this.label_Bodyposition.Location = new System.Drawing.Point(12, 36);
            this.label_Bodyposition.Name = "label_Bodyposition";
            this.label_Bodyposition.Size = new System.Drawing.Size(104, 16);
            this.label_Bodyposition.TabIndex = 1;
            this.label_Bodyposition.Text = "<Body Position>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 221);
            this.Controls.Add(this.label_Bodyposition);
            this.Controls.Add(this.label_Timer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Label label_Bodyposition;
    }
}

