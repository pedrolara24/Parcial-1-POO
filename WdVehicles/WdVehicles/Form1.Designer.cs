namespace WdVehicles
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
            this.rdoCab = new System.Windows.Forms.RadioButton();
            this.rdoBus = new System.Windows.Forms.RadioButton();
            this.rdoParticular = new System.Windows.Forms.RadioButton();
            this.grpTipoVehicle = new System.Windows.Forms.GroupBox();
            this.grpInfoVehicle = new System.Windows.Forms.GroupBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblPlaque = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtPlaque = new System.Windows.Forms.TextBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.grpTipoVehicle.SuspendLayout();
            this.grpInfoVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoCab
            // 
            this.rdoCab.AutoSize = true;
            this.rdoCab.Location = new System.Drawing.Point(6, 31);
            this.rdoCab.Name = "rdoCab";
            this.rdoCab.Size = new System.Drawing.Size(45, 17);
            this.rdoCab.TabIndex = 0;
            this.rdoCab.TabStop = true;
            this.rdoCab.Text = "Taxi";
            this.rdoCab.UseVisualStyleBackColor = true;
            // 
            // rdoBus
            // 
            this.rdoBus.AutoSize = true;
            this.rdoBus.Location = new System.Drawing.Point(6, 54);
            this.rdoBus.Name = "rdoBus";
            this.rdoBus.Size = new System.Drawing.Size(43, 17);
            this.rdoBus.TabIndex = 1;
            this.rdoBus.TabStop = true;
            this.rdoBus.Text = "Bus";
            this.rdoBus.UseVisualStyleBackColor = true;
            // 
            // rdoParticular
            // 
            this.rdoParticular.AutoSize = true;
            this.rdoParticular.Location = new System.Drawing.Point(6, 77);
            this.rdoParticular.Name = "rdoParticular";
            this.rdoParticular.Size = new System.Drawing.Size(69, 17);
            this.rdoParticular.TabIndex = 2;
            this.rdoParticular.TabStop = true;
            this.rdoParticular.Text = "Particular";
            this.rdoParticular.UseVisualStyleBackColor = false;
            // 
            // grpTipoVehicle
            // 
            this.grpTipoVehicle.Controls.Add(this.rdoCab);
            this.grpTipoVehicle.Controls.Add(this.rdoBus);
            this.grpTipoVehicle.Controls.Add(this.rdoParticular);
            this.grpTipoVehicle.Location = new System.Drawing.Point(33, 48);
            this.grpTipoVehicle.Name = "grpTipoVehicle";
            this.grpTipoVehicle.Size = new System.Drawing.Size(245, 107);
            this.grpTipoVehicle.TabIndex = 3;
            this.grpTipoVehicle.TabStop = false;
            this.grpTipoVehicle.Text = "Tipo De Vehiculo";
            // 
            // grpInfoVehicle
            // 
            this.grpInfoVehicle.Controls.Add(this.txtPower);
            this.grpInfoVehicle.Controls.Add(this.lblPower);
            this.grpInfoVehicle.Controls.Add(this.txtBrand);
            this.grpInfoVehicle.Controls.Add(this.lblPlaque);
            this.grpInfoVehicle.Controls.Add(this.txtColour);
            this.grpInfoVehicle.Controls.Add(this.lblBrand);
            this.grpInfoVehicle.Controls.Add(this.txtModel);
            this.grpInfoVehicle.Controls.Add(this.lblModel);
            this.grpInfoVehicle.Controls.Add(this.txtPlaque);
            this.grpInfoVehicle.Controls.Add(this.lblColour);
            this.grpInfoVehicle.Location = new System.Drawing.Point(39, 206);
            this.grpInfoVehicle.Name = "grpInfoVehicle";
            this.grpInfoVehicle.Size = new System.Drawing.Size(303, 196);
            this.grpInfoVehicle.TabIndex = 4;
            this.grpInfoVehicle.TabStop = false;
            this.grpInfoVehicle.Text = "Informacion Del Vehiculo";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(71, 163);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(131, 20);
            this.txtPower.TabIndex = 9;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(10, 166);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(49, 13);
            this.lblPower.TabIndex = 9;
            this.lblPower.Text = "Potencia";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(71, 134);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(131, 20);
            this.txtBrand.TabIndex = 8;
            // 
            // lblPlaque
            // 
            this.lblPlaque.AutoSize = true;
            this.lblPlaque.Location = new System.Drawing.Point(18, 43);
            this.lblPlaque.Name = "lblPlaque";
            this.lblPlaque.Size = new System.Drawing.Size(34, 13);
            this.lblPlaque.TabIndex = 5;
            this.lblPlaque.Text = "Placa";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(71, 105);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(131, 20);
            this.txtColour.TabIndex = 7;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(15, 141);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(37, 13);
            this.lblBrand.TabIndex = 8;
            this.lblBrand.Text = "Marca";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(71, 72);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(131, 20);
            this.txtModel.TabIndex = 6;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(10, 75);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(42, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Modelo";
            // 
            // txtPlaque
            // 
            this.txtPlaque.Location = new System.Drawing.Point(71, 40);
            this.txtPlaque.Name = "txtPlaque";
            this.txtPlaque.Size = new System.Drawing.Size(131, 20);
            this.txtPlaque.TabIndex = 5;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(15, 108);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(31, 13);
            this.lblColour.TabIndex = 7;
            this.lblColour.Text = "Color";
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(515, 249);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(181, 38);
            this.btnCapture.TabIndex = 5;
            this.btnCapture.Text = "Capturar";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(527, 340);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(159, 45);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Mostrar";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 457);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.grpInfoVehicle);
            this.Controls.Add(this.grpTipoVehicle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTipoVehicle.ResumeLayout(false);
            this.grpTipoVehicle.PerformLayout();
            this.grpInfoVehicle.ResumeLayout(false);
            this.grpInfoVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoCab;
        private System.Windows.Forms.RadioButton rdoBus;
        private System.Windows.Forms.RadioButton rdoParticular;
        private System.Windows.Forms.GroupBox grpTipoVehicle;
        private System.Windows.Forms.GroupBox grpInfoVehicle;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblPlaque;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPlaque;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnShow;
    }
}

