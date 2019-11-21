namespace MaintenanceComposants
{
    partial class Fm_menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_service = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 119);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu diplome";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_diplome_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 119);
            this.button2.TabIndex = 1;
            this.button2.Text = "Menu employe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bt_employe);
            // 
            // bt_service
            // 
            this.bt_service.Location = new System.Drawing.Point(570, 149);
            this.bt_service.Name = "bt_service";
            this.bt_service.Size = new System.Drawing.Size(174, 119);
            this.bt_service.TabIndex = 2;
            this.bt_service.Text = "Menu service";
            this.bt_service.UseVisualStyleBackColor = true;
            this.bt_service.Click += new System.EventHandler(this.bt_service_Click);
            // 
            // Fm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_service);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Fm_menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_service;
    }
}

