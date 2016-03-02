namespace LeapSigningMotion
{
    partial class FrameDataForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
/*        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayID = new System.Windows.Forms.TextBox();
            this.displayTimestamp = new System.Windows.Forms.TextBox();
            this.displayFPS = new System.Windows.Forms.TextBox();
            this.displayIsValid = new System.Windows.Forms.TextBox();
            this.displayGestureCount = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Timestamp = new System.Windows.Forms.Label();
            this.FPS = new System.Windows.Forms.Label();
            this.IsValid = new System.Windows.Forms.Label();
            this.GestureCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayID
            // 
            this.displayID.Location = new System.Drawing.Point(334, 93);
            this.displayID.Name = "displayID";
            this.displayID.Size = new System.Drawing.Size(206, 20);
            this.displayID.TabIndex = 0;
            // 
            // displayTimestamp
            // 
            this.displayTimestamp.Location = new System.Drawing.Point(334, 133);
            this.displayTimestamp.Name = "displayTimestamp";
            this.displayTimestamp.Size = new System.Drawing.Size(206, 20);
            this.displayTimestamp.TabIndex = 1;
            // 
            // displayFPS
            // 
            this.displayFPS.Location = new System.Drawing.Point(334, 171);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(206, 20);
            this.displayFPS.TabIndex = 2;
            // 
            // displayIsValid
            // 
            this.displayIsValid.Location = new System.Drawing.Point(334, 213);
            this.displayIsValid.Name = "displayIsValid";
            this.displayIsValid.Size = new System.Drawing.Size(206, 20);
            this.displayIsValid.TabIndex = 3;
            // 
            // displayGestureCount
            // 
            this.displayGestureCount.Location = new System.Drawing.Point(334, 253);
            this.displayGestureCount.Name = "displayGestureCount";
            this.displayGestureCount.Size = new System.Drawing.Size(206, 20);
            this.displayGestureCount.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(256, 96);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // Timestamp
            // 
            this.Timestamp.AutoSize = true;
            this.Timestamp.Location = new System.Drawing.Point(256, 136);
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.Size = new System.Drawing.Size(58, 13);
            this.Timestamp.TabIndex = 7;
            this.Timestamp.Text = "Timestamp";
            // 
            // FPS
            // 
            this.FPS.AutoSize = true;
            this.FPS.Location = new System.Drawing.Point(256, 174);
            this.FPS.Name = "FPS";
            this.FPS.Size = new System.Drawing.Size(27, 13);
            this.FPS.TabIndex = 8;
            this.FPS.Text = "FPS";
            // 
            // IsValid
            // 
            this.IsValid.AutoSize = true;
            this.IsValid.Location = new System.Drawing.Point(256, 216);
            this.IsValid.Name = "IsValid";
            this.IsValid.Size = new System.Drawing.Size(38, 13);
            this.IsValid.TabIndex = 9;
            this.IsValid.Text = "IsValid";
            // 
            // GestureCount
            // 
            this.GestureCount.AutoSize = true;
            this.GestureCount.Location = new System.Drawing.Point(256, 256);
            this.GestureCount.Name = "GestureCount";
            this.GestureCount.Size = new System.Drawing.Size(72, 13);
            this.GestureCount.TabIndex = 10;
            this.GestureCount.Text = "GestureCount";
            // 
            // FrameDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 435);
            this.Controls.Add(this.GestureCount);
            this.Controls.Add(this.IsValid);
            this.Controls.Add(this.FPS);
            this.Controls.Add(this.Timestamp);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.displayGestureCount);
            this.Controls.Add(this.displayIsValid);
            this.Controls.Add(this.displayFPS);
            this.Controls.Add(this.displayTimestamp);
            this.Controls.Add(this.displayID);
            this.Name = "FrameDataForm";
            this.Text = "WinFormSample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayID;
        private System.Windows.Forms.TextBox displayTimestamp;
        private System.Windows.Forms.TextBox displayFPS;
        private System.Windows.Forms.TextBox displayIsValid;
        private System.Windows.Forms.TextBox displayGestureCount;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Timestamp;
        private System.Windows.Forms.Label FPS;
        private System.Windows.Forms.Label IsValid;
        private System.Windows.Forms.Label GestureCount;

    }
}

