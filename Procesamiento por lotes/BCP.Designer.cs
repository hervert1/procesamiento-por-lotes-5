namespace Procesamiento_por_lotes
{
    partial class BCP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Estado,
            this.Status,
            this.Operación,
            this.Resultado,
            this.TL,
            this.TF,
            this.TME,
            this.TR,
            this.TRes,
            this.TE,
            this.TS});
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Operación
            // 
            this.Operación.HeaderText = "Operación";
            this.Operación.Name = "Operación";
            this.Operación.ReadOnly = true;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            // 
            // TL
            // 
            this.TL.HeaderText = "Tiempo Llegada";
            this.TL.Name = "TL";
            this.TL.ReadOnly = true;
            // 
            // TF
            // 
            this.TF.HeaderText = "Tiempo Finalización";
            this.TF.Name = "TF";
            this.TF.ReadOnly = true;
            // 
            // TME
            // 
            this.TME.HeaderText = "Tiempo Maximo";
            this.TME.Name = "TME";
            this.TME.ReadOnly = true;
            // 
            // TR
            // 
            this.TR.HeaderText = "Tiempo de Retorno";
            this.TR.Name = "TR";
            this.TR.ReadOnly = true;
            // 
            // TRes
            // 
            this.TRes.HeaderText = "Tiempo de Respuesta";
            this.TRes.Name = "TRes";
            this.TRes.ReadOnly = true;
            // 
            // TE
            // 
            this.TE.HeaderText = "Tiempo de Espera";
            this.TE.Name = "TE";
            this.TE.ReadOnly = true;
            // 
            // TS
            // 
            this.TS.HeaderText = "Tiempo de Servicio";
            this.TS.Name = "TS";
            this.TS.ReadOnly = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Green;
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(478, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(28, 13);
            this.title.TabIndex = 1;
            this.title.Text = "BCP";
            // 
            // BCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Procesamiento_por_lotes.Properties.Resources.wp1876255;
            this.ClientSize = new System.Drawing.Size(1265, 421);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "BCP";
            this.RightToLeftLayout = true;
            this.Text = "BCP";
            this.Load += new System.EventHandler(this.BCP_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BCP_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BCP_KeyPress);
            this.Leave += new System.EventHandler(this.BCP_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TS;
        public System.Windows.Forms.Label title;
    }
}