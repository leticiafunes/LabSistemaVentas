namespace WindowsApp
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
            this.btnGenerarClases = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.listDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerarClases
            // 
            this.btnGenerarClases.Location = new System.Drawing.Point(66, 150);
            this.btnGenerarClases.Name = "btnGenerarClases";
            this.btnGenerarClases.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarClases.TabIndex = 0;
            this.btnGenerarClases.Text = "Generar Clases";
            this.btnGenerarClases.UseVisualStyleBackColor = true;
            this.btnGenerarClases.Click += new System.EventHandler(this.btnGenerarClases_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(66, 179);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // listDatos
            // 
            this.listDatos.FormattingEnabled = true;
            this.listDatos.ItemHeight = 15;
            this.listDatos.Location = new System.Drawing.Point(195, 12);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(427, 334);
            this.listDatos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listDatos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGenerarClases);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGenerarClases;
        private Button btnMostrar;
        private ListBox listDatos;
    }
}