namespace ArchivoXML_5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grillaGenero = new System.Windows.Forms.DataGridView();
            this.btn_serializar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaGenero
            // 
            this.grillaGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaGenero.Location = new System.Drawing.Point(45, 51);
            this.grillaGenero.MultiSelect = false;
            this.grillaGenero.Name = "grillaGenero";
            this.grillaGenero.ReadOnly = true;
            this.grillaGenero.RowTemplate.Height = 24;
            this.grillaGenero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaGenero.Size = new System.Drawing.Size(685, 150);
            this.grillaGenero.TabIndex = 0;
            // 
            // btn_serializar
            // 
            this.btn_serializar.Location = new System.Drawing.Point(45, 266);
            this.btn_serializar.Name = "btn_serializar";
            this.btn_serializar.Size = new System.Drawing.Size(137, 23);
            this.btn_serializar.TabIndex = 1;
            this.btn_serializar.Text = "Serializar";
            this.btn_serializar.UseVisualStyleBackColor = true;
            this.btn_serializar.Click += new System.EventHandler(this.btn_serializar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Location = new System.Drawing.Point(131, 348);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(254, 22);
            this.txt_nombre_usuario.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_serializar);
            this.Controls.Add(this.grillaGenero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaGenero;
        private System.Windows.Forms.Button btn_serializar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
    }
}

