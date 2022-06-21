namespace Vista
{
    partial class frmPRINCIPAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRINCIPAL));
            this.label1 = new System.Windows.Forms.Label();
            this.btnINICIARSESION = new System.Windows.Forms.Button();
            this.btnREGISTRARME = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido!";
            // 
            // btnINICIARSESION
            // 
            this.btnINICIARSESION.Location = new System.Drawing.Point(39, 100);
            this.btnINICIARSESION.Name = "btnINICIARSESION";
            this.btnINICIARSESION.Size = new System.Drawing.Size(116, 23);
            this.btnINICIARSESION.TabIndex = 1;
            this.btnINICIARSESION.Text = "Iniciar Sesion";
            this.btnINICIARSESION.UseVisualStyleBackColor = true;
            this.btnINICIARSESION.Click += new System.EventHandler(this.btnINICIARSESION_Click);
            // 
            // btnREGISTRARME
            // 
            this.btnREGISTRARME.Location = new System.Drawing.Point(39, 129);
            this.btnREGISTRARME.Name = "btnREGISTRARME";
            this.btnREGISTRARME.Size = new System.Drawing.Size(116, 23);
            this.btnREGISTRARME.TabIndex = 2;
            this.btnREGISTRARME.Text = "Registrarme";
            this.btnREGISTRARME.UseVisualStyleBackColor = true;
            this.btnREGISTRARME.Click += new System.EventHandler(this.btnREGISTRARME_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(39, 167);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(116, 23);
            this.btnSALIR.TabIndex = 3;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "2K-Pizza";
            // 
            // frmPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(193, 204);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnREGISTRARME);
            this.Controls.Add(this.btnINICIARSESION);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPRINCIPAL";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPRINCIPAL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnINICIARSESION;
        private System.Windows.Forms.Button btnREGISTRARME;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Label label2;
    }
}

