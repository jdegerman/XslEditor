namespace XslEditor
{
    partial class SelectSchemaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseSchema = new System.Windows.Forms.Button();
            this.txtSchemaPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseInstance = new System.Windows.Forms.Button();
            this.txtInstancePath = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseSchema);
            this.groupBox1.Controls.Add(this.txtSchemaPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schema";
            // 
            // btnBrowseSchema
            // 
            this.btnBrowseSchema.Location = new System.Drawing.Point(280, 17);
            this.btnBrowseSchema.Name = "btnBrowseSchema";
            this.btnBrowseSchema.Size = new System.Drawing.Size(32, 23);
            this.btnBrowseSchema.TabIndex = 1;
            this.btnBrowseSchema.Text = "...";
            this.btnBrowseSchema.UseVisualStyleBackColor = true;
            this.btnBrowseSchema.Click += new System.EventHandler(this.btnBrowseSchema_Click);
            // 
            // txtSchemaPath
            // 
            this.txtSchemaPath.Location = new System.Drawing.Point(6, 19);
            this.txtSchemaPath.Name = "txtSchemaPath";
            this.txtSchemaPath.Size = new System.Drawing.Size(268, 20);
            this.txtSchemaPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowseInstance);
            this.groupBox2.Controls.Add(this.txtInstancePath);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instance";
            // 
            // btnBrowseInstance
            // 
            this.btnBrowseInstance.Location = new System.Drawing.Point(280, 17);
            this.btnBrowseInstance.Name = "btnBrowseInstance";
            this.btnBrowseInstance.Size = new System.Drawing.Size(32, 23);
            this.btnBrowseInstance.TabIndex = 1;
            this.btnBrowseInstance.Text = "...";
            this.btnBrowseInstance.UseVisualStyleBackColor = true;
            this.btnBrowseInstance.Click += new System.EventHandler(this.btnBrowseInstance_Click);
            // 
            // txtInstancePath
            // 
            this.txtInstancePath.Location = new System.Drawing.Point(6, 19);
            this.txtInstancePath.Name = "txtInstancePath";
            this.txtInstancePath.Size = new System.Drawing.Size(268, 20);
            this.txtInstancePath.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(174, 142);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SelectSchemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectSchemaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select schema...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseSchema;
        private System.Windows.Forms.TextBox txtSchemaPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowseInstance;
        private System.Windows.Forms.TextBox txtInstancePath;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}