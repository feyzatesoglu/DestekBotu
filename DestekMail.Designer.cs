
namespace AskMeProject
{
    partial class DestekMail
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxİcerik = new System.Windows.Forms.TextBox();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-posta :";
            // 
            // textBoxEposta
            // 
            this.textBoxEposta.Location = new System.Drawing.Point(131, 53);
            this.textBoxEposta.Name = "textBoxEposta";
            this.textBoxEposta.Size = new System.Drawing.Size(313, 22);
            this.textBoxEposta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu :";
            // 
            // textBoxKonu
            // 
            this.textBoxKonu.Location = new System.Drawing.Point(131, 123);
            this.textBoxKonu.Name = "textBoxKonu";
            this.textBoxKonu.Size = new System.Drawing.Size(313, 22);
            this.textBoxKonu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "İçerik :";
            // 
            // textBoxİcerik
            // 
            this.textBoxİcerik.Location = new System.Drawing.Point(131, 187);
            this.textBoxİcerik.Multiline = true;
            this.textBoxİcerik.Name = "textBoxİcerik";
            this.textBoxİcerik.Size = new System.Drawing.Size(313, 141);
            this.textBoxİcerik.TabIndex = 5;
            // 
            // buttonGonder
            // 
            this.buttonGonder.Location = new System.Drawing.Point(223, 371);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(118, 44);
            this.buttonGonder.TabIndex = 6;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // DestekMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.textBoxİcerik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEposta);
            this.Controls.Add(this.label1);
            this.Name = "DestekMail";
            this.Text = "DestekMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxİcerik;
        private System.Windows.Forms.Button buttonGonder;
    }
}