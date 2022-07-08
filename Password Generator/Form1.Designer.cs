namespace Password_Generator
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
            this.txtvisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvisor
            // 
            this.txtvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvisor.Location = new System.Drawing.Point(102, 184);
            this.txtvisor.Name = "txtvisor";
            this.txtvisor.Size = new System.Drawing.Size(276, 29);
            this.txtvisor.TabIndex = 0;
            this.txtvisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "New password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnstart
            // 
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Location = new System.Drawing.Point(102, 144);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(102, 23);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnreset
            // 
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Location = new System.Drawing.Point(276, 144);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(102, 23);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generate your new password!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Password_Generator.Properties.Resources.minimize_window_icon_472389;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(426, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 15);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = global::Password_Generator.Properties.Resources._558_5589628_close_button_icon_png_clipart_png_download_close;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(454, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(16, 15);
            this.btnclose.TabIndex = 5;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtChar
            // 
            this.txtChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar.Location = new System.Drawing.Point(204, 109);
            this.txtChar.MaxLength = 3;
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(75, 29);
            this.txtChar.TabIndex = 7;
            this.txtChar.TextChanged += new System.EventHandler(this.txtChar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Characters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Label label3;
    }
}

