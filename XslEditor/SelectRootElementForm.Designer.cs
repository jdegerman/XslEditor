namespace XslEditor
{
    partial class SelectRootElementForm
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
            this.cbSelectRootElement = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSelectRootElement
            // 
            this.cbSelectRootElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectRootElement.FormattingEnabled = true;
            this.cbSelectRootElement.Location = new System.Drawing.Point(12, 12);
            this.cbSelectRootElement.Name = "cbSelectRootElement";
            this.cbSelectRootElement.Size = new System.Drawing.Size(337, 21);
            this.cbSelectRootElement.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(274, 39);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // SelectRootElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 76);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbSelectRootElement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectRootElementForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select root element";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectRootElement;
        private System.Windows.Forms.Button btnSelect;
    }
}