namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    partial class UtilizadoresGridView
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
            this.components = new System.ComponentModel.Container();
            this.psi18_afonsosalvadorDataSet = new TGPSI18H_2218147_AfonsoSalvador_M16.psi18_afonsosalvadorDataSet();
            this.psi18afonsosalvadorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.psi18_afonsosalvadorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psi18afonsosalvadorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // psi18_afonsosalvadorDataSet
            // 
            this.psi18_afonsosalvadorDataSet.DataSetName = "psi18_afonsosalvadorDataSet";
            this.psi18_afonsosalvadorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // psi18afonsosalvadorDataSetBindingSource
            // 
            this.psi18afonsosalvadorDataSetBindingSource.DataSource = this.psi18_afonsosalvadorDataSet;
            this.psi18afonsosalvadorDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.psi18afonsosalvadorDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(248, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // UtilizadoresGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "UtilizadoresGridView";
            this.Size = new System.Drawing.Size(1153, 558);
            ((System.ComponentModel.ISupportInitialize)(this.psi18_afonsosalvadorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psi18afonsosalvadorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource psi18afonsosalvadorDataSetBindingSource;
        private psi18_afonsosalvadorDataSet psi18_afonsosalvadorDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
