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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xSLTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplyXSLT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToggleValidateInput = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToggleValidateOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstContainer = new System.Windows.Forms.SplitContainer();
            this.tabSource = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeSourceSchema = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeSourceFile = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SecondContainer = new System.Windows.Forms.SplitContainer();
            this.xslEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.contextMenuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditorInsertValueOf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditorInsertTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditorInsertApplyTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditorApplyPrettyPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDestination = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.treeDestinationSchema = new System.Windows.Forms.TreeView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.treeDestinationFile = new System.Windows.Forms.TreeView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.contextMenuDestination = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDestinationGenerateXML = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDestinationExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDestinationCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditorInsertIf = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditorInsertChoose = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
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
            this.contextMenuEditor.SuspendLayout();
            this.tabDestination.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.contextMenuDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "cog.png");
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xSLTToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1014, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItem2.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(118, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // xSLTToolStripMenuItem
            // 
            this.xSLTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApplyXSLT,
            this.menuToggleValidateInput,
            this.menuToggleValidateOutput});
            this.xSLTToolStripMenuItem.Name = "xSLTToolStripMenuItem";
            this.xSLTToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.xSLTToolStripMenuItem.Text = "XSLT";
            // 
            // menuApplyXSLT
            // 
            this.menuApplyXSLT.Name = "menuApplyXSLT";
            this.menuApplyXSLT.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuApplyXSLT.Size = new System.Drawing.Size(152, 22);
            this.menuApplyXSLT.Text = "Apply";
            this.menuApplyXSLT.Click += new System.EventHandler(this.menuApplyXSLT_Click);
            // 
            // menuToggleValidateInput
            // 
            this.menuToggleValidateInput.Name = "menuToggleValidateInput";
            this.menuToggleValidateInput.Size = new System.Drawing.Size(152, 22);
            this.menuToggleValidateInput.Text = "Validate input";
            this.menuToggleValidateInput.Click += new System.EventHandler(this.menuToggleValidateInput_Click);
            // 
            // menuToggleValidateOutput
            // 
            this.menuToggleValidateOutput.Name = "menuToggleValidateOutput";
            this.menuToggleValidateOutput.Size = new System.Drawing.Size(152, 22);
            this.menuToggleValidateOutput.Text = "Validate result";
            this.menuToggleValidateOutput.Click += new System.EventHandler(this.menuToggleValidateOutput_Click);
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
            this.tabPage2.Size = new System.Drawing.Size(201, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeSourceFile
            // 
            this.treeSourceFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSourceFile.Location = new System.Drawing.Point(3, 3);
            this.treeSourceFile.Name = "treeSourceFile";
            this.treeSourceFile.Size = new System.Drawing.Size(195, 603);
            this.treeSourceFile.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "cog.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(201, 609);
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
            this.SecondContainer.SplitterDistance = 541;
            this.SecondContainer.TabIndex = 0;
            // 
            // xslEditor
            // 
            this.xslEditor.ContextMenuStrip = this.contextMenuEditor;
            this.xslEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xslEditor.IsReadOnly = false;
            this.xslEditor.Location = new System.Drawing.Point(0, 0);
            this.xslEditor.Name = "xslEditor";
            this.xslEditor.Size = new System.Drawing.Size(539, 636);
            this.xslEditor.TabIndex = 0;
            this.xslEditor.Text = resources.GetString("xslEditor.Text");
            // 
            // contextMenuEditor
            // 
            this.contextMenuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xSLToolStripMenuItem,
            this.menuEditorApplyPrettyPrint});
            this.contextMenuEditor.Name = "contextMenuEditor";
            this.contextMenuEditor.Size = new System.Drawing.Size(134, 48);
            // 
            // xSLToolStripMenuItem
            // 
            this.xSLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditorInsertValueOf,
            this.menuEditorInsertTemplate,
            this.menuEditorInsertApplyTemplate,
            this.menuEditorInsertIf,
            this.menuEditorInsertChoose});
            this.xSLToolStripMenuItem.Name = "xSLToolStripMenuItem";
            this.xSLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xSLToolStripMenuItem.Text = "XSL";
            // 
            // menuEditorInsertValueOf
            // 
            this.menuEditorInsertValueOf.Name = "menuEditorInsertValueOf";
            this.menuEditorInsertValueOf.Size = new System.Drawing.Size(160, 22);
            this.menuEditorInsertValueOf.Text = "value-of";
            this.menuEditorInsertValueOf.Click += new System.EventHandler(this.menuEditorInsertValueOf_Click);
            // 
            // menuEditorInsertTemplate
            // 
            this.menuEditorInsertTemplate.Name = "menuEditorInsertTemplate";
            this.menuEditorInsertTemplate.Size = new System.Drawing.Size(160, 22);
            this.menuEditorInsertTemplate.Text = "template";
            this.menuEditorInsertTemplate.Click += new System.EventHandler(this.menuEditorInsertTemplate_Click);
            // 
            // menuEditorInsertApplyTemplate
            // 
            this.menuEditorInsertApplyTemplate.Name = "menuEditorInsertApplyTemplate";
            this.menuEditorInsertApplyTemplate.Size = new System.Drawing.Size(160, 22);
            this.menuEditorInsertApplyTemplate.Text = "apply-templates";
            this.menuEditorInsertApplyTemplate.Click += new System.EventHandler(this.menuEditorInsertValueOfApplyTemplate_Click);
            // 
            // menuEditorApplyPrettyPrint
            // 
            this.menuEditorApplyPrettyPrint.Name = "menuEditorApplyPrettyPrint";
            this.menuEditorApplyPrettyPrint.Size = new System.Drawing.Size(152, 22);
            this.menuEditorApplyPrettyPrint.Text = "Pretty print";
            this.menuEditorApplyPrettyPrint.Click += new System.EventHandler(this.menuEditorApplyPrettyPrint_Click);
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
            this.tabDestination.Size = new System.Drawing.Size(252, 636);
            this.tabDestination.TabIndex = 2;
            this.tabDestination.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.treeDestinationSchema);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(244, 609);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Schema";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // treeDestinationSchema
            // 
            this.treeDestinationSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDestinationSchema.FullRowSelect = true;
            this.treeDestinationSchema.Location = new System.Drawing.Point(3, 3);
            this.treeDestinationSchema.Name = "treeDestinationSchema";
            this.treeDestinationSchema.PathSeparator = "/";
            this.treeDestinationSchema.Size = new System.Drawing.Size(238, 603);
            this.treeDestinationSchema.TabIndex = 1;
            this.treeDestinationSchema.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDestinationSchema_NodeMouseClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.treeDestinationFile);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(244, 607);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "XML";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // treeDestinationFile
            // 
            this.treeDestinationFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDestinationFile.Location = new System.Drawing.Point(3, 3);
            this.treeDestinationFile.Name = "treeDestinationFile";
            this.treeDestinationFile.Size = new System.Drawing.Size(238, 601);
            this.treeDestinationFile.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.ImageKey = "cog.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(244, 607);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // contextMenuDestination
            // 
            this.contextMenuDestination.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDestinationGenerateXML,
            this.menuDestinationExpandAll,
            this.menuDestinationCollapseAll});
            this.contextMenuDestination.Name = "contextMenuDestination";
            this.contextMenuDestination.Size = new System.Drawing.Size(149, 70);
            // 
            // menuDestinationGenerateXML
            // 
            this.menuDestinationGenerateXML.Name = "menuDestinationGenerateXML";
            this.menuDestinationGenerateXML.Size = new System.Drawing.Size(148, 22);
            this.menuDestinationGenerateXML.Text = "Generate XML";
            this.menuDestinationGenerateXML.Click += new System.EventHandler(this.menuDestinationGenerateXML_Click);
            // 
            // menuDestinationExpandAll
            // 
            this.menuDestinationExpandAll.Name = "menuDestinationExpandAll";
            this.menuDestinationExpandAll.Size = new System.Drawing.Size(148, 22);
            this.menuDestinationExpandAll.Text = "Expand all";
            this.menuDestinationExpandAll.Click += new System.EventHandler(this.menuExpandAllGeneric_Click);
            // 
            // menuDestinationCollapseAll
            // 
            this.menuDestinationCollapseAll.Name = "menuDestinationCollapseAll";
            this.menuDestinationCollapseAll.Size = new System.Drawing.Size(148, 22);
            this.menuDestinationCollapseAll.Text = "Collapse all";
            this.menuDestinationCollapseAll.Click += new System.EventHandler(this.menuCollapseAllGeneric_Click);
            // 
            // menuEditorInsertIf
            // 
            this.menuEditorInsertIf.Name = "menuEditorInsertIf";
            this.menuEditorInsertIf.Size = new System.Drawing.Size(160, 22);
            this.menuEditorInsertIf.Text = "if";
            this.menuEditorInsertIf.Click += new System.EventHandler(this.menuEditorInsertIf_Click);
            // 
            // menuEditorInsertChoose
            // 
            this.menuEditorInsertChoose.Name = "menuEditorInsertChoose";
            this.menuEditorInsertChoose.Size = new System.Drawing.Size(160, 22);
            this.menuEditorInsertChoose.Text = "choose";
            this.menuEditorInsertChoose.Click += new System.EventHandler(this.menuEditorInsertChoose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 662);
            this.Controls.Add(this.FirstContainer);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "XSLT Editor";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
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
            this.contextMenuEditor.ResumeLayout(false);
            this.tabDestination.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.contextMenuDestination.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.MenuStrip mainMenu;
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xSLTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuApplyXSLT;
        private System.Windows.Forms.ToolStripMenuItem menuToggleValidateInput;
        private System.Windows.Forms.ToolStripMenuItem menuToggleValidateOutput;
        private System.Windows.Forms.ContextMenuStrip contextMenuDestination;
        private System.Windows.Forms.ToolStripMenuItem menuDestinationGenerateXML;
        private System.Windows.Forms.ToolStripMenuItem menuDestinationExpandAll;
        private System.Windows.Forms.ToolStripMenuItem menuDestinationCollapseAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuEditor;
        private System.Windows.Forms.ToolStripMenuItem xSLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEditorInsertValueOf;
        private System.Windows.Forms.ToolStripMenuItem menuEditorInsertTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuEditorInsertApplyTemplate;
        private System.Windows.Forms.ToolStripMenuItem menuEditorApplyPrettyPrint;
        private System.Windows.Forms.ToolStripMenuItem menuEditorInsertIf;
        private System.Windows.Forms.ToolStripMenuItem menuEditorInsertChoose;



    }
}

