namespace TrabalhoQuinta
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
            this.lstAnimais = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAnimais
            // 
            this.lstAnimais.FormattingEnabled = true;
            this.lstAnimais.ItemHeight = 15;
            this.lstAnimais.Location = new System.Drawing.Point(12, 12);
            this.lstAnimais.Name = "lstAnimais";
            this.lstAnimais.Size = new System.Drawing.Size(155, 409);
            this.lstAnimais.TabIndex = 0;
            this.lstAnimais.SelectedIndexChanged += new System.EventHandler(this.lstAnimais_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(223, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(155, 23);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 70);
            this.button4.TabIndex = 5;
            this.button4.Text = "Salvar no Banco";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lstAnimais);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstAnimais;
        private TextBox textBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}