namespace XslEditor
{
    partial class TransformationResultForm
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
            this.xslResult = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // xslResult
            // 
            this.xslResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xslResult.IsReadOnly = false;
            this.xslResult.Location = new System.Drawing.Point(0, 0);
            this.xslResult.Name = "xslResult";
            this.xslResult.Size = new System.Drawing.Size(546, 431);
            this.xslResult.TabIndex = 1;
            // 
            // TransformationResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 431);
            this.Controls.Add(this.xslResult);
            this.Name = "TransformationResultForm";
            this.Text = "Output";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransformationResultForm_FormClosing);
            this.Load += new System.EventHandler(this.TransformationResultForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl xslResult;
    }
}