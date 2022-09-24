namespace Primeiro_Projeto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.ButtonVerificar = new System.Windows.Forms.Button();
            this.Subtitle = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ButtonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(91, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(183, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "Ímpar ou Par?";
            // 
            // ButtonVerificar
            // 
            this.ButtonVerificar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonVerificar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVerificar.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonVerificar.Location = new System.Drawing.Point(148, 113);
            this.ButtonVerificar.Name = "ButtonVerificar";
            this.ButtonVerificar.Size = new System.Drawing.Size(75, 23);
            this.ButtonVerificar.TabIndex = 1;
            this.ButtonVerificar.Text = "Verificar";
            this.ButtonVerificar.UseVisualStyleBackColor = false;
            this.ButtonVerificar.Click += new System.EventHandler(this.ButtonVerificar_Click);
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(105, 45);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(155, 23);
            this.Subtitle.TabIndex = 2;
            this.Subtitle.Text = "Digite um número";
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(135, 71);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 27);
            this.InputBox.TabIndex = 3;
            // 
            // ButtonLimpar
            // 
            this.ButtonLimpar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ButtonLimpar.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonLimpar.Location = new System.Drawing.Point(302, 144);
            this.ButtonLimpar.Name = "ButtonLimpar";
            this.ButtonLimpar.Size = new System.Drawing.Size(58, 23);
            this.ButtonLimpar.TabIndex = 4;
            this.ButtonLimpar.Text = "Limpar";
            this.ButtonLimpar.UseVisualStyleBackColor = false;
            this.ButtonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(372, 179);
            this.Controls.Add(this.ButtonLimpar);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.ButtonVerificar);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Projeto Impar ou Par?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ButtonVerificar;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button ButtonLimpar;
    }
}

