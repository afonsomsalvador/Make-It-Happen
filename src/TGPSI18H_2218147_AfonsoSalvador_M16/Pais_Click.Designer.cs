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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.voluntariadO_CLICK1 = new TGPSI18H_2218147_AfonsoSalvador_M16.VOLUNTARIADO_CLICK();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LCD5x8H", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(73, 35);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 323);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint);
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
            this.voluntariadO_CLICK1.IDRegisto = 0;
            this.voluntariadO_CLICK1.image = null;
            this.voluntariadO_CLICK1.Lingua = null;
            this.voluntariadO_CLICK1.Localidade = null;
            this.voluntariadO_CLICK1.Location = new System.Drawing.Point(0, 0);
            this.voluntariadO_CLICK1.Name = "voluntariadO_CLICK1";
            this.voluntariadO_CLICK1.Nome = null;
            this.voluntariadO_CLICK1.Organizacao = null;
            this.voluntariadO_CLICK1.Seguro = null;
            this.voluntariadO_CLICK1.Size = new System.Drawing.Size(1117, 1232);
            this.voluntariadO_CLICK1.TabIndex = 5;
            this.voluntariadO_CLICK1.Transfers = null;
            this.voluntariadO_CLICK1.Visible = false;
            this.voluntariadO_CLICK1.Load += new System.EventHandler(this.VoluntariadO_CLICK1_Load);
            // 
            // Pais_Click
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voluntariadO_CLICK1);
            this.Name = "Pais_Click";
            this.Size = new System.Drawing.Size(796, 407);
            this.Load += new System.EventHandler(this.Pais_Click_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private VOLUNTARIADO_CLICK voluntariadO_CLICK1;
    }
}
