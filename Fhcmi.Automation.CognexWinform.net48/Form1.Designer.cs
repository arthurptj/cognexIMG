namespace Fhcmi.Automation.CognexWinform.net48
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.Trigger = new System.Windows.Forms.Button();
            this.InputExposure = new System.Windows.Forms.NumericUpDown();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btStream = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cogAcqFifoEditV21 = new Cognex.VisionPro.CogAcqFifoEditV2();
            this.cogAcqFifoEditV22 = new Cognex.VisionPro.CogAcqFifoEditV2();
            this.cogAcqFifoEditV23 = new Cognex.VisionPro.CogAcqFifoEditV2();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputExposure)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV23)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1161F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 1161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btDisconnect, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.Trigger, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.InputExposure, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbStatus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btConnect, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btStream, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(94, 1155);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDisconnect.Location = new System.Drawing.Point(3, 253);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(88, 44);
            this.btDisconnect.TabIndex = 8;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            // 
            // Trigger
            // 
            this.Trigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Trigger.Location = new System.Drawing.Point(3, 153);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(88, 44);
            this.Trigger.TabIndex = 6;
            this.Trigger.Text = "Trigger";
            this.Trigger.UseVisualStyleBackColor = true;
            this.Trigger.Click += new System.EventHandler(this.Trigger_Click);
            // 
            // InputExposure
            // 
            this.InputExposure.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InputExposure.Location = new System.Drawing.Point(3, 128);
            this.InputExposure.Name = "InputExposure";
            this.InputExposure.Size = new System.Drawing.Size(88, 20);
            this.InputExposure.TabIndex = 4;
            this.InputExposure.ValueChanged += new System.EventHandler(this.InputExposure_ValueChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Location = new System.Drawing.Point(3, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(88, 50);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "***";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConnect
            // 
            this.btConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConnect.Location = new System.Drawing.Point(3, 53);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(88, 44);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Brightness";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStream
            // 
            this.btStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btStream.Location = new System.Drawing.Point(3, 203);
            this.btStream.Name = "btStream";
            this.btStream.Size = new System.Drawing.Size(88, 44);
            this.btStream.TabIndex = 7;
            this.btStream.Text = "Stream";
            this.btStream.UseVisualStyleBackColor = true;
            this.btStream.Click += new System.EventHandler(this.btStream_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cogAcqFifoEditV23, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cogAcqFifoEditV22, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cogAcqFifoEditV21, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(103, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33533F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(878, 1155);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // cogAcqFifoEditV21
            // 
            this.cogAcqFifoEditV21.Location = new System.Drawing.Point(3, 388);
            this.cogAcqFifoEditV21.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogAcqFifoEditV21.Name = "cogAcqFifoEditV21";
            this.cogAcqFifoEditV21.Size = new System.Drawing.Size(835, 378);
            this.cogAcqFifoEditV21.SuspendElectricRuns = false;
            this.cogAcqFifoEditV21.TabIndex = 3;
            // 
            // cogAcqFifoEditV22
            // 
            this.cogAcqFifoEditV22.Location = new System.Drawing.Point(3, 3);
            this.cogAcqFifoEditV22.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogAcqFifoEditV22.Name = "cogAcqFifoEditV22";
            this.cogAcqFifoEditV22.Size = new System.Drawing.Size(835, 378);
            this.cogAcqFifoEditV22.SuspendElectricRuns = false;
            this.cogAcqFifoEditV22.TabIndex = 4;
            // 
            // cogAcqFifoEditV23
            // 
            this.cogAcqFifoEditV23.Location = new System.Drawing.Point(3, 772);
            this.cogAcqFifoEditV23.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogAcqFifoEditV23.Name = "cogAcqFifoEditV23";
            this.cogAcqFifoEditV23.Size = new System.Drawing.Size(835, 378);
            this.cogAcqFifoEditV23.SuspendElectricRuns = false;
            this.cogAcqFifoEditV23.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 1161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputExposure)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogAcqFifoEditV23)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Trigger;
        private System.Windows.Forms.NumericUpDown InputExposure;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStream;
        private System.Windows.Forms.Button btDisconnect;
        private Cognex.VisionPro.CogAcqFifoEditV2 cogAcqFifoEditV21;
        private Cognex.VisionPro.CogAcqFifoEditV2 cogAcqFifoEditV23;
        private Cognex.VisionPro.CogAcqFifoEditV2 cogAcqFifoEditV22;
    }
}

