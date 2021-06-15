namespace III_2020
{
    partial class UserControl1
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
            this.IniciarJuegoButton = new System.Windows.Forms.Button();
            this.ComprobarButton = new System.Windows.Forms.Button();
            this.IntentoTextBox = new System.Windows.Forms.TextBox();
            this.IntentosLabel = new System.Windows.Forms.Label();
            this.FaltalLabel = new System.Windows.Forms.Label();
            this.ResultadosLabel = new System.Windows.Forms.Label();
            this.AciertosParcialesLabel = new System.Windows.Forms.Label();
            this.AciertosTotalesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IniciarJuegoButton
            // 
            this.IniciarJuegoButton.Location = new System.Drawing.Point(489, 29);
            this.IniciarJuegoButton.Name = "IniciarJuegoButton";
            this.IniciarJuegoButton.Size = new System.Drawing.Size(350, 70);
            this.IniciarJuegoButton.TabIndex = 0;
            this.IniciarJuegoButton.Text = "Iniciar Juego";
            this.IniciarJuegoButton.UseVisualStyleBackColor = true;
            this.IniciarJuegoButton.Click += new System.EventHandler(this.IniciarJuegoButton_Click);
            // 
            // ComprobarButton
            // 
            this.ComprobarButton.Location = new System.Drawing.Point(812, 182);
            this.ComprobarButton.Name = "ComprobarButton";
            this.ComprobarButton.Size = new System.Drawing.Size(178, 63);
            this.ComprobarButton.TabIndex = 1;
            this.ComprobarButton.Text = "Comprobar";
            this.ComprobarButton.UseVisualStyleBackColor = true;
            this.ComprobarButton.Click += new System.EventHandler(this.ComprobarButton_Click);
            // 
            // IntentoTextBox
            // 
            this.IntentoTextBox.Location = new System.Drawing.Point(239, 200);
            this.IntentoTextBox.Name = "IntentoTextBox";
            this.IntentoTextBox.Size = new System.Drawing.Size(357, 26);
            this.IntentoTextBox.TabIndex = 2;
            // 
            // IntentosLabel
            // 
            this.IntentosLabel.AutoSize = true;
            this.IntentosLabel.Location = new System.Drawing.Point(838, 329);
            this.IntentosLabel.Name = "IntentosLabel";
            this.IntentosLabel.Size = new System.Drawing.Size(76, 20);
            this.IntentosLabel.TabIndex = 3;
            this.IntentosLabel.Text = "Intentos: ";
            // 
            // FaltalLabel
            // 
            this.FaltalLabel.AutoSize = true;
            this.FaltalLabel.Location = new System.Drawing.Point(838, 429);
            this.FaltalLabel.Name = "FaltalLabel";
            this.FaltalLabel.Size = new System.Drawing.Size(62, 20);
            this.FaltalLabel.TabIndex = 4;
            this.FaltalLabel.Text = "Faltan: ";
            // 
            // ResultadosLabel
            // 
            this.ResultadosLabel.AutoSize = true;
            this.ResultadosLabel.Location = new System.Drawing.Point(262, 329);
            this.ResultadosLabel.Name = "ResultadosLabel";
            this.ResultadosLabel.Size = new System.Drawing.Size(164, 30);
            this.ResultadosLabel.TabIndex = 5;
            this.ResultadosLabel.Text = "Ultimo Intento";
            this.ResultadosLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // AciertosParcialesLabel
            // 
            this.AciertosParcialesLabel.AutoSize = true;
            this.AciertosParcialesLabel.Location = new System.Drawing.Point(262, 429);
            this.AciertosParcialesLabel.Name = "AciertosParcialesLabel";
            this.AciertosParcialesLabel.Size = new System.Drawing.Size(143, 20);
            this.AciertosParcialesLabel.TabIndex = 6;
            this.AciertosParcialesLabel.Text = "Aciertos Parciales: ";
            // 
            // AciertosTotalesLabel
            // 
            this.AciertosTotalesLabel.AutoSize = true;
            this.AciertosTotalesLabel.Location = new System.Drawing.Point(262, 516);
            this.AciertosTotalesLabel.Name = "AciertosTotalesLabel";
            this.AciertosTotalesLabel.Size = new System.Drawing.Size(131, 20);
            this.AciertosTotalesLabel.TabIndex = 7;
            this.AciertosTotalesLabel.Text = "Aciertos Totales: ";
            this.AciertosTotalesLabel.Click += new System.EventHandler(this.AciertosTotalesLabel_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AciertosTotalesLabel);
            this.Controls.Add(this.AciertosParcialesLabel);
            this.Controls.Add(this.ResultadosLabel);
            this.Controls.Add(this.FaltalLabel);
            this.Controls.Add(this.IntentosLabel);
            this.Controls.Add(this.IntentoTextBox);
            this.Controls.Add(this.ComprobarButton);
            this.Controls.Add(this.IniciarJuegoButton);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1347, 764);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IniciarJuegoButton;
        private System.Windows.Forms.Button ComprobarButton;
        private System.Windows.Forms.TextBox IntentoTextBox;
        private System.Windows.Forms.Label IntentosLabel;
        private System.Windows.Forms.Label FaltalLabel;
        private System.Windows.Forms.Label ResultadosLabel;
        private System.Windows.Forms.Label AciertosParcialesLabel;
        private System.Windows.Forms.Label AciertosTotalesLabel;
    }
}
