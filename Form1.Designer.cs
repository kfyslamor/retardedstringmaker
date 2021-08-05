
namespace StringToStRIngG
{
    partial class String_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(String_Form));
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxRetarded = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelAppName = new System.Windows.Forms.Label();
            this.buttonAppExit = new System.Windows.Forms.Button();
            this.buttonEntryHeader = new System.Windows.Forms.Button();
            this.labelAbout = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBoxOriginal.Location = new System.Drawing.Point(12, 193);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(396, 25);
            this.textBoxOriginal.TabIndex = 0;
            this.textBoxOriginal.TextChanged += new System.EventHandler(this.textBoxOriginal_TextChanged);
            // 
            // textBoxRetarded
            // 
            this.textBoxRetarded.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxRetarded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBoxRetarded.Location = new System.Drawing.Point(6, 333);
            this.textBoxRetarded.Name = "textBoxRetarded";
            this.textBoxRetarded.Size = new System.Drawing.Size(402, 25);
            this.textBoxRetarded.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelTop.Controls.Add(this.labelAppName);
            this.panelTop.Controls.Add(this.buttonAppExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(417, 29);
            this.panelTop.TabIndex = 26;
            // 
            // labelAppName
            // 
            this.labelAppName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelAppName.Image = ((System.Drawing.Image)(resources.GetObject("labelAppName.Image")));
            this.labelAppName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAppName.Location = new System.Drawing.Point(3, 3);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(189, 23);
            this.labelAppName.TabIndex = 24;
            this.labelAppName.Text = "     Retarded String Maker";
            this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAppExit
            // 
            this.buttonAppExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAppExit.FlatAppearance.BorderSize = 0;
            this.buttonAppExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonAppExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonAppExit.Location = new System.Drawing.Point(391, 3);
            this.buttonAppExit.Name = "buttonAppExit";
            this.buttonAppExit.Size = new System.Drawing.Size(23, 23);
            this.buttonAppExit.TabIndex = 22;
            this.buttonAppExit.Text = "X";
            this.buttonAppExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAppExit.UseVisualStyleBackColor = true;
            this.buttonAppExit.Click += new System.EventHandler(this.buttonAppExit_Click);
            // 
            // buttonEntryHeader
            // 
            this.buttonEntryHeader.FlatAppearance.BorderSize = 0;
            this.buttonEntryHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.buttonEntryHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.buttonEntryHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEntryHeader.Location = new System.Drawing.Point(6, 35);
            this.buttonEntryHeader.Name = "buttonEntryHeader";
            this.buttonEntryHeader.Size = new System.Drawing.Size(402, 60);
            this.buttonEntryHeader.TabIndex = 37;
            this.buttonEntryHeader.Text = "Retarded String Maker";
            this.buttonEntryHeader.UseVisualStyleBackColor = true;
            this.buttonEntryHeader.Click += new System.EventHandler(this.buttonEntryHeader_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelAbout.Location = new System.Drawing.Point(340, 618);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(68, 25);
            this.labelAbout.TabIndex = 38;
            this.labelAbout.Text = "About";
            this.labelAbout.Click += new System.EventHandler(this.label1_Click);
            // 
            // String_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(417, 652);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.buttonEntryHeader);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.textBoxRetarded);
            this.Controls.Add(this.textBoxOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "String_Form";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxRetarded;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Button buttonAppExit;
        private System.Windows.Forms.Button buttonEntryHeader;
        private System.Windows.Forms.Label labelAbout;
    }
}

