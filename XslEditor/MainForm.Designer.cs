namespace XslEditor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FirstContainer = new System.Windows.Forms.SplitContainer();
            this.tabSource = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeSourceSchema = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeSourceFile = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SecondContainer = new System.Windows.Forms.SplitContainer();
            this.xslEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.tabDestination = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.treeDestinationSchema = new System.Windows.Forms.TreeView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.treeDestinationFile = new System.Windows.Forms.TreeView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.FirstContainer)).BeginInit();
            this.FirstContainer.Panel1.SuspendLayout();
            this.FirstContainer.Panel2.SuspendLayout();
            this.FirstContainer.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondContainer)).BeginInit();
            this.SecondContainer.Panel1.SuspendLayout();
            this.SecondContainer.Panel2.SuspendLayout();
            this.SecondContainer.SuspendLayout();
            this.tabDestination.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "cog.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FirstContainer
            // 
            this.FirstContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstContainer.Location = new System.Drawing.Point(0, 24);
            this.FirstContainer.Name = "FirstContainer";
            // 
            // FirstContainer.Panel1
            // 
            this.FirstContainer.Panel1.Controls.Add(this.tabSource);
            // 
            // FirstContainer.Panel2
            // 
            this.FirstContainer.Panel2.Controls.Add(this.SecondContainer);
            this.FirstContainer.Size = new System.Drawing.Size(1014, 638);
            this.FirstContainer.SplitterDistance = 211;
            this.FirstContainer.TabIndex = 2;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.tabPage1);
            this.tabSource.Controls.Add(this.tabPage2);
            this.tabSource.Controls.Add(this.tabPage3);
            this.tabSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSource.ImageList = this.iconList;
            this.tabSource.Location = new System.Drawing.Point(0, 0);
            this.tabSource.Name = "tabSource";
            this.tabSource.SelectedIndex = 0;
            this.tabSource.Size = new System.Drawing.Size(209, 636);
            this.tabSource.TabIndex = 1;
            this.tabSource.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeSourceSchema);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(201, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schema";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeSourceSchema
            // 
            this.treeSourceSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSourceSchema.Location = new System.Drawing.Point(3, 3);
            this.treeSourceSchema.Name = "treeSourceSchema";
            this.treeSourceSchema.Size = new System.Drawing.Size(195, 603);
            this.treeSourceSchema.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeSourceFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(201, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeSourceFile
            // 
            this.treeSourceFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSourceFile.Location = new System.Drawing.Point(3, 3);
            this.treeSourceFile.Name = "treeSourceFile";
            this.treeSourceFile.Size = new System.Drawing.Size(195, 627);
            this.treeSourceFile.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "cog.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(201, 633);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SecondContainer
            // 
            this.SecondContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SecondContainer.Location = new System.Drawing.Point(0, 0);
            this.SecondContainer.Name = "SecondContainer";
            // 
            // SecondContainer.Panel1
            // 
            this.SecondContainer.Panel1.Controls.Add(this.xslEditor);
            // 
            // SecondContainer.Panel2
            // 
            this.SecondContainer.Panel2.Controls.Add(this.tabDestination);
            this.SecondContainer.Size = new System.Drawing.Size(799, 638);
            this.SecondContainer.SplitterDistance = 595;
            this.SecondContainer.TabIndex = 0;
            // 
            // xslEditor
            // 
            this.xslEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xslEditor.IsReadOnly = false;
            this.xslEditor.Location = new System.Drawing.Point(0, 0);
            this.xslEditor.Name = "xslEditor";
            this.xslEditor.Size = new System.Drawing.Size(593, 636);
            this.xslEditor.TabIndex = 0;
            // 
            // tabDestination
            // 
            this.tabDestination.Controls.Add(this.tabPage4);
            this.tabDestination.Controls.Add(this.tabPage5);
            this.tabDestination.Controls.Add(this.tabPage6);
            this.tabDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDestination.ImageList = this.iconList;
            this.tabDestination.Location = new System.Drawing.Point(0, 0);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.SelectedIndex = 0;
            this.tabDestination.Size = new System.Drawing.Size(198, 636);
            this.tabDestination.TabIndex = 2;
            this.tabDestination.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.treeDestinationSchema);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(190, 609);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Schema";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // treeDestinationSchema
            // 
            this.treeDestinationSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDestinationSchema.Location = new System.Drawing.Point(3, 3);
            this.treeDestinationSchema.Name = "treeDestinationSchema";
            this.treeDestinationSchema.Size = new System.Drawing.Size(184, 603);
            this.treeDestinationSchema.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.treeDestinationFile);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(190, 633);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "XML";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // treeDestinationFile
            // 
            this.treeDestinationFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDestinationFile.Location = new System.Drawing.Point(3, 3);
            this.treeDestinationFile.Name = "treeDestinationFile";
            this.treeDestinationFile.Size = new System.Drawing.Size(184, 627);
            this.treeDestinationFile.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.ImageKey = "cog.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(190, 633);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 662);
            this.Controls.Add(this.FirstContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "XSLT Editor";
            this.FirstContainer.Panel1.ResumeLayout(false);
            this.FirstContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstContainer)).EndInit();
            this.FirstContainer.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.SecondContainer.Panel1.ResumeLayout(false);
            this.SecondContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecondContainer)).EndInit();
            this.SecondContainer.ResumeLayout(false);
            this.tabDestination.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer FirstContainer;
        private System.Windows.Forms.TabControl tabSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeSourceSchema;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeSourceFile;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer SecondContainer;
        private ICSharpCode.TextEditor.TextEditorControl xslEditor;
        private System.Windows.Forms.TabControl tabDestination;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TreeView treeDestinationSchema;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TreeView treeDestinationFile;
        private System.Windows.Forms.TabPage tabPage6;



    }
}

