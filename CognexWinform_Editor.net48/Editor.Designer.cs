namespace CognexWinform_Editor.net48
{
    partial class Editor
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
            this.cogToolGroupEditV21 = new Cognex.VisionPro.ToolGroup.CogToolGroupEditV2();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolGroupEditV21)).BeginInit();
            this.SuspendLayout();
            // 
            // cogToolGroupEditV21
            // 
            this.cogToolGroupEditV21.AllowDrop = true;
            this.cogToolGroupEditV21.ContextMenuCustomizer = null;
            this.cogToolGroupEditV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogToolGroupEditV21.Location = new System.Drawing.Point(0, 0);
            this.cogToolGroupEditV21.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogToolGroupEditV21.Name = "cogToolGroupEditV21";
            this.cogToolGroupEditV21.ShowNodeToolTips = true;
            this.cogToolGroupEditV21.Size = new System.Drawing.Size(984, 461);
            this.cogToolGroupEditV21.SuspendElectricRuns = false;
            this.cogToolGroupEditV21.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.cogToolGroupEditV21);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cogToolGroupEditV21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cognex.VisionPro.ToolGroup.CogToolGroupEditV2 cogToolGroupEditV21;
    }
}

