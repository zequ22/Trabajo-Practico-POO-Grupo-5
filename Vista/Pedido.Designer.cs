namespace Vista
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPEDIDO = new System.Windows.Forms.ComboBox();
            this.cmbBEBIDA = new System.Windows.Forms.ComboBox();
            this.cbSI = new System.Windows.Forms.CheckBox();
            this.cbNO = new System.Windows.Forms.CheckBox();
            this.gbENVIO = new System.Windows.Forms.GroupBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtDOMICILIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCOMPRAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.gbENVIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domicilio:";
            // 
            // cmbPEDIDO
            // 
            this.cmbPEDIDO.FormattingEnabled = true;
            this.cmbPEDIDO.Location = new System.Drawing.Point(15, 79);
            this.cmbPEDIDO.Name = "cmbPEDIDO";
            this.cmbPEDIDO.Size = new System.Drawing.Size(224, 21);
            this.cmbPEDIDO.TabIndex = 2;
            // 
            // cmbBEBIDA
            // 
            this.cmbBEBIDA.FormattingEnabled = true;
            this.cmbBEBIDA.Location = new System.Drawing.Point(258, 79);
            this.cmbBEBIDA.Name = "cmbBEBIDA";
            this.cmbBEBIDA.Size = new System.Drawing.Size(224, 21);
            this.cmbBEBIDA.TabIndex = 3;
            // 
            // cbSI
            // 
            this.cbSI.AutoSize = true;
            this.cbSI.Location = new System.Drawing.Point(6, 19);
            this.cbSI.Name = "cbSI";
            this.cbSI.Size = new System.Drawing.Size(35, 17);
            this.cbSI.TabIndex = 4;
            this.cbSI.Text = "Si";
            this.cbSI.UseVisualStyleBackColor = true;
            // 
            // cbNO
            // 
            this.cbNO.AutoSize = true;
            this.cbNO.Location = new System.Drawing.Point(57, 19);
            this.cbNO.Name = "cbNO";
            this.cbNO.Size = new System.Drawing.Size(40, 17);
            this.cbNO.TabIndex = 5;
            this.cbNO.Text = "No";
            this.cbNO.UseVisualStyleBackColor = true;
            // 
            // gbENVIO
            // 
            this.gbENVIO.Controls.Add(this.cbSI);
            this.gbENVIO.Controls.Add(this.cbNO);
            this.gbENVIO.Location = new System.Drawing.Point(15, 130);
            this.gbENVIO.Name = "gbENVIO";
            this.gbENVIO.Size = new System.Drawing.Size(105, 49);
            this.gbENVIO.TabIndex = 6;
            this.gbENVIO.TabStop = false;
            this.gbENVIO.Text = "Envio a Domicilio";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(65, 6);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.ReadOnly = true;
            this.txtNOMBRE.Size = new System.Drawing.Size(174, 20);
            this.txtNOMBRE.TabIndex = 7;
            // 
            // txtDOMICILIO
            // 
            this.txtDOMICILIO.Location = new System.Drawing.Point(313, 6);
            this.txtDOMICILIO.Name = "txtDOMICILIO";
            this.txtDOMICILIO.ReadOnly = true;
            this.txtDOMICILIO.Size = new System.Drawing.Size(169, 20);
            this.txtDOMICILIO.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bebida:";
            // 
            // btnCOMPRAR
            // 
            this.btnCOMPRAR.Location = new System.Drawing.Point(258, 156);
            this.btnCOMPRAR.Name = "btnCOMPRAR";
            this.btnCOMPRAR.Size = new System.Drawing.Size(108, 23);
            this.btnCOMPRAR.TabIndex = 11;
            this.btnCOMPRAR.Text = "Comprar";
            this.btnCOMPRAR.UseVisualStyleBackColor = true;
            this.btnCOMPRAR.Click += new System.EventHandler(this.btnCOMPRAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(372, 156);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(110, 23);
            this.btnSALIR.TabIndex = 12;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(503, 227);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnCOMPRAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDOMICILIO);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.gbENVIO);
            this.Controls.Add(this.cmbBEBIDA);
            this.Controls.Add(this.cmbPEDIDO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.gbENVIO.ResumeLayout(false);
            this.gbENVIO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPEDIDO;
        private System.Windows.Forms.ComboBox cmbBEBIDA;
        private System.Windows.Forms.CheckBox cbSI;
        private System.Windows.Forms.CheckBox cbNO;
        private System.Windows.Forms.GroupBox gbENVIO;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtDOMICILIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCOMPRAR;
        private System.Windows.Forms.Button btnSALIR;
    }
}