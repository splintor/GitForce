namespace GitForce.Settings.Panels
{
    partial class ControlMultipleInstances
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
            this.chkWarnMultipleInstances = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkWarnMultipleInstances
            // 
            this.chkWarnMultipleInstances.AutoSize = true;
            this.chkWarnMultipleInstances.Location = new System.Drawing.Point(0, 0);
            this.chkWarnMultipleInstances.Name = "chkWarnMultipleInstances";
            this.chkWarnMultipleInstances.Size = new System.Drawing.Size(268, 17);
            this.chkWarnMultipleInstances.TabIndex = 0;
            this.chkWarnMultipleInstances.Text = "&Warn before starting additional instance of GitForce";
            this.chkWarnMultipleInstances.UseVisualStyleBackColor = true;
            // 
            // ControlMultipleInstances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkWarnMultipleInstances);
            this.Name = "ControlMultipleInstances";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkWarnMultipleInstances;
    }
}
