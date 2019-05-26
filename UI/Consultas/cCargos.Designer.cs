namespace Registro
{
    partial class cConsultas
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.consultarB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Criterio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtro";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Id",
            "Descripcion",
            "Todos"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(12, 27);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(169, 21);
            this.FiltrocomboBox.TabIndex = 6;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(217, 28);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(267, 20);
            this.CriterioTextBox.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(600, 258);
            this.dataGridView.TabIndex = 9;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // consultarB
            // 
            this.consultarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarB.Image = global::Registro.Properties.Resources.Buscar;
            this.consultarB.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.consultarB.Location = new System.Drawing.Point(506, 11);
            this.consultarB.Name = "consultarB";
            this.consultarB.Size = new System.Drawing.Size(106, 37);
            this.consultarB.TabIndex = 19;
            this.consultarB.Text = "           Consultar";
            this.consultarB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.consultarB.UseVisualStyleBackColor = true;
            this.consultarB.Click += new System.EventHandler(this.ConsultarB_Click);
            // 
            // cConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 324);
            this.Controls.Add(this.consultarB);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "cConsultas";
            this.Text = "cConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button consultarB;
    }
}