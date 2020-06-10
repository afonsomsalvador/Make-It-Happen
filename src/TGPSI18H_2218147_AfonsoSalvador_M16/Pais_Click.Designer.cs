namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    partial class Pais_Click
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pais_Click));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voluntariadO_CLICK1 = new TGPSI18H_2218147_AfonsoSalvador_M16.VOLUNTARIADO_CLICK();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LCD5x8H", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(257, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 240);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(910, 337);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisa";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(227, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // voluntariadO_CLICK1
            // 
            this.voluntariadO_CLICK1.Acompanhamento = null;
            this.voluntariadO_CLICK1.Adicional = null;
            this.voluntariadO_CLICK1.Alimentacao = null;
            this.voluntariadO_CLICK1.Alojamento = null;
            this.voluntariadO_CLICK1.AutoScroll = true;
            this.voluntariadO_CLICK1.AutoSize = true;
            this.voluntariadO_CLICK1.Categoria = null;
            this.voluntariadO_CLICK1.Data = null;
            this.voluntariadO_CLICK1.Descricao = null;
            this.voluntariadO_CLICK1.Duracao = null;
            this.voluntariadO_CLICK1.Escolaridade = null;
            this.voluntariadO_CLICK1.Idade = null;
            this.voluntariadO_CLICK1.image = null;
            this.voluntariadO_CLICK1.Lingua = null;
            this.voluntariadO_CLICK1.Localidade = null;
            this.voluntariadO_CLICK1.Location = new System.Drawing.Point(0, 0);
            this.voluntariadO_CLICK1.Name = "voluntariadO_CLICK1";
            this.voluntariadO_CLICK1.Nome = null;
            this.voluntariadO_CLICK1.Organizacao = null;
            this.voluntariadO_CLICK1.Seguro = null;
            this.voluntariadO_CLICK1.Size = new System.Drawing.Size(1117, 1212);
            this.voluntariadO_CLICK1.TabIndex = 5;
            this.voluntariadO_CLICK1.Transfers = null;
            this.voluntariadO_CLICK1.Visible = false;
            // 
            // Pais_Click
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voluntariadO_CLICK1);
            this.Name = "Pais_Click";
            this.Size = new System.Drawing.Size(949, 560);
            this.Load += new System.EventHandler(this.Pais_Click_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private VOLUNTARIADO_CLICK voluntariadO_CLICK1;
    }
}
