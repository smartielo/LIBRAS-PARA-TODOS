using System.Windows.Forms;
using System.Xml.Linq;


namespace LIBRAS_PARA_TODOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAlfabeto = new Button();
            btnNumSin = new Button();
            btnJogo = new Button();
            btnQuem = new Button();
            btnLibras = new Button();
            btn_imagemSaida = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAlfabeto
            // 
            btnAlfabeto.BackColor = Color.Transparent;
            btnAlfabeto.BackgroundImage = (Image)resources.GetObject("btnAlfabeto.BackgroundImage");
            btnAlfabeto.BackgroundImageLayout = ImageLayout.Zoom;
            btnAlfabeto.Cursor = Cursors.Hand;
            btnAlfabeto.FlatAppearance.BorderSize = 0;
            btnAlfabeto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAlfabeto.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAlfabeto.FlatStyle = FlatStyle.Flat;
            btnAlfabeto.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAlfabeto.Location = new Point(106, 59);
            btnAlfabeto.Name = "btnAlfabeto";
            btnAlfabeto.Size = new Size(268, 96);
            btnAlfabeto.TabIndex = 5;
            btnAlfabeto.UseVisualStyleBackColor = true;
            btnAlfabeto.Click += btnAlfabeto_Click;
            // 
            // btnNumSin
            // 
            btnNumSin.BackColor = Color.Transparent;
            btnNumSin.BackgroundImage = (Image)resources.GetObject("btnNumSin.BackgroundImage");
            btnNumSin.BackgroundImageLayout = ImageLayout.Stretch;
            btnNumSin.Cursor = Cursors.Hand;
            btnNumSin.FlatAppearance.BorderSize = 0;
            btnNumSin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNumSin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNumSin.FlatStyle = FlatStyle.Flat;
            btnNumSin.Location = new Point(200, 523);
            btnNumSin.Name = "btnNumSin";
            btnNumSin.Size = new Size(268, 96);
            btnNumSin.TabIndex = 6;
            btnNumSin.UseVisualStyleBackColor = false;
            btnNumSin.Click += btnNumSin_Click;
            // 
            // btnJogo
            // 
            btnJogo.BackColor = Color.Transparent;
            btnJogo.BackgroundImage = (Image)resources.GetObject("btnJogo.BackgroundImage");
            btnJogo.BackgroundImageLayout = ImageLayout.Zoom;
            btnJogo.Cursor = Cursors.Hand;
            btnJogo.FlatAppearance.BorderSize = 0;
            btnJogo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnJogo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnJogo.FlatStyle = FlatStyle.Flat;
            btnJogo.Location = new Point(456, 59);
            btnJogo.Name = "btnJogo";
            btnJogo.Size = new Size(268, 96);
            btnJogo.TabIndex = 7;
            btnJogo.UseVisualStyleBackColor = false;
            btnJogo.Click += btnJogo_Click;
            // 
            // btnQuem
            // 
            btnQuem.BackColor = Color.Transparent;
            btnQuem.BackgroundImage = (Image)resources.GetObject("btnQuem.BackgroundImage");
            btnQuem.BackgroundImageLayout = ImageLayout.Zoom;
            btnQuem.Cursor = Cursors.Hand;
            btnQuem.FlatAppearance.BorderSize = 0;
            btnQuem.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnQuem.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnQuem.FlatStyle = FlatStyle.Flat;
            btnQuem.Location = new Point(838, 59);
            btnQuem.Name = "btnQuem";
            btnQuem.Size = new Size(268, 96);
            btnQuem.TabIndex = 8;
            btnQuem.UseVisualStyleBackColor = false;
            btnQuem.Click += btnQuem_Click;
            // 
            // btnLibras
            // 
            btnLibras.BackColor = Color.Transparent;
            btnLibras.BackgroundImage = (Image)resources.GetObject("btnLibras.BackgroundImage");
            btnLibras.BackgroundImageLayout = ImageLayout.Stretch;
            btnLibras.Cursor = Cursors.Hand;
            btnLibras.FlatAppearance.BorderSize = 0;
            btnLibras.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLibras.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLibras.FlatStyle = FlatStyle.Flat;
            btnLibras.Location = new Point(663, 523);
            btnLibras.Name = "btnLibras";
            btnLibras.Size = new Size(268, 96);
            btnLibras.TabIndex = 10;
            btnLibras.UseVisualStyleBackColor = false;
            btnLibras.Click += btnLibras_Click;
            // 
            // btn_imagemSaida
            // 
            btn_imagemSaida.BackColor = Color.Transparent;
            btn_imagemSaida.BackgroundImage = (Image)resources.GetObject("btn_imagemSaida.BackgroundImage");
            btn_imagemSaida.BackgroundImageLayout = ImageLayout.Stretch;
            btn_imagemSaida.Cursor = Cursors.Hand;
            btn_imagemSaida.FlatAppearance.BorderSize = 0;
            btn_imagemSaida.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_imagemSaida.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_imagemSaida.FlatStyle = FlatStyle.Flat;
            btn_imagemSaida.Location = new Point(12, 12);
            btn_imagemSaida.Name = "btn_imagemSaida";
            btn_imagemSaida.Size = new Size(97, 78);
            btn_imagemSaida.TabIndex = 11;
            btn_imagemSaida.UseVisualStyleBackColor = false;
            btn_imagemSaida.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(237, 187, 48);
            label1.Location = new Point(76, 386);
            label1.Name = "label1";
            label1.Size = new Size(392, 69);
            label1.TabIndex = 12;
            label1.Text = "PARA TODOS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImage = Properties.Resources.fundo_principal;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1147, 645);
            Controls.Add(label1);
            Controls.Add(btn_imagemSaida);
            Controls.Add(btnLibras);
            Controls.Add(btnQuem);
            Controls.Add(btnJogo);
            Controls.Add(btnNumSin);
            Controls.Add(btnAlfabeto);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1147, 645);
            MinimumSize = new Size(1147, 645);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LIBRAS PARA TODOS";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAlfabeto;
        private Button btnNumSin;
        private Button btnJogo;
        private Button btnQuem;
        private Button btnLibras;
        private Button btn_imagemSaida;
        private Label label1;
    }
}
