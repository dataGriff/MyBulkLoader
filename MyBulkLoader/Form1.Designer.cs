namespace MyBulkLoader
{
    partial class formBulkLoad
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblLastLoad = new System.Windows.Forms.Label();
            this.txtSourceConnString = new System.Windows.Forms.TextBox();
            this.txtDestConnString = new System.Windows.Forms.TextBox();
            this.txtSourceObject = new System.Windows.Forms.TextBox();
            this.txtDestObject = new System.Windows.Forms.TextBox();
            this.chkTruncate = new System.Windows.Forms.CheckBox();
            this.cmbxSourceConnectionString = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(289, 314);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblLastLoad
            // 
            this.lblLastLoad.AutoSize = true;
            this.lblLastLoad.Location = new System.Drawing.Point(60, 402);
            this.lblLastLoad.Name = "lblLastLoad";
            this.lblLastLoad.Size = new System.Drawing.Size(112, 13);
            this.lblLastLoad.TabIndex = 2;
            this.lblLastLoad.Text = "Load Summary Report";
            // 
            // txtSourceConnString
            // 
            this.txtSourceConnString.Location = new System.Drawing.Point(240, 42);
            this.txtSourceConnString.Name = "txtSourceConnString";
            this.txtSourceConnString.Size = new System.Drawing.Size(171, 20);
            this.txtSourceConnString.TabIndex = 3;
            // 
            // txtDestConnString
            // 
            this.txtDestConnString.Location = new System.Drawing.Point(240, 95);
            this.txtDestConnString.Name = "txtDestConnString";
            this.txtDestConnString.Size = new System.Drawing.Size(171, 20);
            this.txtDestConnString.TabIndex = 4;
            // 
            // txtSourceObject
            // 
            this.txtSourceObject.Location = new System.Drawing.Point(240, 147);
            this.txtSourceObject.Name = "txtSourceObject";
            this.txtSourceObject.Size = new System.Drawing.Size(171, 20);
            this.txtSourceObject.TabIndex = 5;
            // 
            // txtDestObject
            // 
            this.txtDestObject.Location = new System.Drawing.Point(240, 197);
            this.txtDestObject.Name = "txtDestObject";
            this.txtDestObject.Size = new System.Drawing.Size(171, 20);
            this.txtDestObject.TabIndex = 6;
            // 
            // chkTruncate
            // 
            this.chkTruncate.AutoSize = true;
            this.chkTruncate.Checked = true;
            this.chkTruncate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTruncate.Location = new System.Drawing.Point(434, 197);
            this.chkTruncate.Name = "chkTruncate";
            this.chkTruncate.Size = new System.Drawing.Size(131, 17);
            this.chkTruncate.TabIndex = 7;
            this.chkTruncate.Text = "Truncate Destination?";
            this.chkTruncate.UseVisualStyleBackColor = true;
            // 
            // cmbxSourceConnectionString
            // 
            this.cmbxSourceConnectionString.FormattingEnabled = true;
            this.cmbxSourceConnectionString.Location = new System.Drawing.Point(447, 42);
            this.cmbxSourceConnectionString.Name = "cmbxSourceConnectionString";
            this.cmbxSourceConnectionString.Size = new System.Drawing.Size(121, 21);
            this.cmbxSourceConnectionString.TabIndex = 8;
            // 
            // formBulkLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 563);
            this.Controls.Add(this.cmbxSourceConnectionString);
            this.Controls.Add(this.chkTruncate);
            this.Controls.Add(this.txtDestObject);
            this.Controls.Add(this.txtSourceObject);
            this.Controls.Add(this.txtDestConnString);
            this.Controls.Add(this.txtSourceConnString);
            this.Controls.Add(this.lblLastLoad);
            this.Controls.Add(this.btnLoad);
            this.Name = "formBulkLoad";
            this.Text = "Bulk Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblLastLoad;
        private System.Windows.Forms.TextBox txtSourceConnString;
        private System.Windows.Forms.TextBox txtDestConnString;
        private System.Windows.Forms.TextBox txtSourceObject;
        private System.Windows.Forms.TextBox txtDestObject;
        private System.Windows.Forms.CheckBox chkTruncate;
        private System.Windows.Forms.ComboBox cmbxSourceConnectionString;
    }
}

