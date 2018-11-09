namespace LineCalculator
{
    partial class LineFormGUI
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
            this.LblIn = new System.Windows.Forms.Label();
            this.TxtEqn = new System.Windows.Forms.TextBox();
            this.BtnParse = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.LstPoint = new System.Windows.Forms.ListBox();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblIn
            // 
            this.LblIn.AutoSize = true;
            this.LblIn.Location = new System.Drawing.Point(15, 11);
            this.LblIn.Name = "LblIn";
            this.LblIn.Size = new System.Drawing.Size(102, 17);
            this.LblIn.TabIndex = 0;
            this.LblIn.Text = "Insert equation";
            // 
            // TxtEqn
            // 
            this.TxtEqn.Location = new System.Drawing.Point(123, 8);
            this.TxtEqn.Name = "TxtEqn";
            this.TxtEqn.Size = new System.Drawing.Size(172, 22);
            this.TxtEqn.TabIndex = 1;
            // 
            // BtnParse
            // 
            this.BtnParse.Location = new System.Drawing.Point(301, 4);
            this.BtnParse.Name = "BtnParse";
            this.BtnParse.Size = new System.Drawing.Size(98, 30);
            this.BtnParse.TabIndex = 2;
            this.BtnParse.Text = "Parse";
            this.BtnParse.UseVisualStyleBackColor = true;
            this.BtnParse.Click += new System.EventHandler(this.BtnParse_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.BtnParse);
            this.InputPanel.Controls.Add(this.TxtEqn);
            this.InputPanel.Controls.Add(this.LblIn);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(800, 53);
            this.InputPanel.TabIndex = 3;
            // 
            // LstPoint
            // 
            this.LstPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstPoint.FormatString = "N3";
            this.LstPoint.FormattingEnabled = true;
            this.LstPoint.ItemHeight = 16;
            this.LstPoint.Location = new System.Drawing.Point(0, 53);
            this.LstPoint.Name = "LstPoint";
            this.LstPoint.Size = new System.Drawing.Size(800, 397);
            this.LstPoint.TabIndex = 4;
            // 
            // LineFormGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstPoint);
            this.Controls.Add(this.InputPanel);
            this.Name = "LineFormGUI";
            this.Text = "Line calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LineFormGUI_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblIn;
        private System.Windows.Forms.TextBox TxtEqn;
        private System.Windows.Forms.Button BtnParse;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.ListBox LstPoint;
    }
}

