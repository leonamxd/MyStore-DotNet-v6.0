namespace GUI
{
    partial class frmBackupDados
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
            this.btRestaurar = new System.Windows.Forms.Button();
            this.btBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRestaurar
            // 
            this.btRestaurar.Image = global::GUI.Properties.Resources.restart_64px;
            this.btRestaurar.Location = new System.Drawing.Point(139, 63);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(75, 74);
            this.btRestaurar.TabIndex = 0;
            this.btRestaurar.UseVisualStyleBackColor = true;
            // 
            // btBackup
            // 
            this.btBackup.Image = global::GUI.Properties.Resources.data_backup_64px;
            this.btBackup.Location = new System.Drawing.Point(15, 63);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(75, 74);
            this.btBackup.TabIndex = 1;
            this.btBackup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backup de Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Restaurar Dados";
            // 
            // frmBackupDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.btRestaurar);
            this.Name = "frmBackupDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup de Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btRestaurar;
        private Button btBackup;
        private Label label1;
        private Label label2;
    }
}