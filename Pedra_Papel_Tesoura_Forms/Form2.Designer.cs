
namespace Pedra_Papel_Tesoura_Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pontos Jogador 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pontos Jogador 2:";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.Color.Silver;
            this.txtPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlayer1.Enabled = false;
            this.txtPlayer1.Location = new System.Drawing.Point(182, 331);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(29, 13);
            this.txtPlayer1.TabIndex = 5;
            this.txtPlayer1.Text = "0";
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.Color.Silver;
            this.txtPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayer2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlayer2.Enabled = false;
            this.txtPlayer2.Location = new System.Drawing.Point(182, 361);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(29, 13);
            this.txtPlayer2.TabIndex = 6;
            this.txtPlayer2.Text = "0";
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 58);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jogador 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(316, 343);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(36, 31);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPedra
            // 
            this.btnPedra.BackColor = System.Drawing.Color.Coral;
            this.btnPedra.FlatAppearance.BorderSize = 0;
            this.btnPedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedra.Image = ((System.Drawing.Image)(resources.GetObject("btnPedra.Image")));
            this.btnPedra.Location = new System.Drawing.Point(48, 96);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(61, 61);
            this.btnPedra.TabIndex = 9;
            this.btnPedra.UseVisualStyleBackColor = false;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.Color.Teal;
            this.btnPapel.FlatAppearance.BorderSize = 0;
            this.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapel.Image = ((System.Drawing.Image)(resources.GetObject("btnPapel.Image")));
            this.btnPapel.Location = new System.Drawing.Point(160, 96);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(61, 61);
            this.btnPapel.TabIndex = 10;
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackColor = System.Drawing.Color.Yellow;
            this.btnTesoura.FlatAppearance.BorderSize = 0;
            this.btnTesoura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesoura.Image = ((System.Drawing.Image)(resources.GetObject("btnTesoura.Image")));
            this.btnTesoura.Location = new System.Drawing.Point(268, 96);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(61, 61);
            this.btnTesoura.TabIndex = 11;
            this.btnTesoura.UseVisualStyleBackColor = false;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 58);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jogador 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayer2.Enabled = false;
            this.btnPlayer2.FlatAppearance.BorderSize = 0;
            this.btnPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer2.Location = new System.Drawing.Point(160, 244);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(61, 61);
            this.btnPlayer2.TabIndex = 13;
            this.btnPlayer2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(376, 393);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlayer2;
    }
}