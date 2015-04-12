using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XslEditor
{
    public partial class MainForm : Form
    {
        private string sourceSchema = null;
        private string sourceInstance = null;
        private string destinationSchema = null;
        private string destinationInstane = null;
        private bool validateInput = false;
        private bool validateOutput = false;
        private TransformationResultForm results = new TransformationResultForm();
        private TextArea textArea { get { return xslEditor.ActiveTextAreaControl.TextArea; } }
        private IDocument document { get { return textArea.Document; } }
        private SelectionManager selectionManager { get { return textArea.SelectionManager; } }
        private bool textSelected { get { return selectionManager.HasSomethingSelected; } }

        public MainForm()
        {
            InitializeComponent();
            results.Show();
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            var caller = (TabControl)sender;
            if(caller.SelectedIndex != 2)
                return;
            caller.SelectedIndex = 0;
            var isSource = caller.Name == "tabSource";
            var schema = isSource ? sourceSchema : destinationSchema;
            var instance = isSource ? sourceInstance : destinationInstane;
            using(var selectSchema = new SelectSchemaForm(isSource, schema, instance))
            {
                if (selectSchema.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                if(isSource)
                {
                    sourceSchema = selectSchema.XmlSchema;
                    sourceInstance = selectSchema.XmlInstance;
                }
                else
                {
                    destinationSchema = selectSchema.XmlSchema;
                    destinationInstane = selectSchema.XmlInstance;
                }
                var targetTreeSchema = isSource ? treeSourceSchema : treeDestinationSchema;
                var targetTreeInstance = isSource ? treeSourceFile : treeDestinationFile;
                targetTreeSchema.Nodes.Clear();
                targetTreeInstance.Nodes.Clear();
                Enabled = false;
                if (!string.IsNullOrEmpty(selectSchema.XmlSchema))
                    UIService.PopulateSchemaTree(targetTreeSchema, XmlService.CreateSchemaSet, selectSchema.XmlSchema, UIService.SelectRootElementCallback);
                if (!string.IsNullOrEmpty(selectSchema.XmlInstance))
                    UIService.PopulateInstanceTree(targetTreeInstance, XmlService.CreateReader, selectSchema.XmlInstance);
                Enabled = true;
            }
        }

        private void menuToggleValidateInput_Click(object sender, EventArgs e)
        {
            menuToggleValidateInput.Checked = !menuToggleValidateInput.Checked;
            validateInput = menuToggleValidateInput.Checked;
        }

        private void menuToggleValidateOutput_Click(object sender, EventArgs e)
        {
            menuToggleValidateOutput.Checked = !menuToggleValidateOutput.Checked;
            validateOutput = menuToggleValidateOutput.Checked;
        }

        private void menuApplyXSLT_Click(object sender, EventArgs e)
        {
            try
            {
                results.SetText(XmlService.Transform(sourceInstance, xslEditor.Text));
            }
            catch(Exception ex)
            {
                var err = ex.Message;
                ex = ex.InnerException;
                while(ex != null)
                {
                    err += Environment.NewLine + ex.Message;
                    ex = ex.InnerException;
                }
                results.SetText(err);
            }
        }

        private void treeDestinationSchema_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuDestination.Show((Control)sender, e.Location);
            }
        }

        private void menuExpandAllGeneric_Click(object sender, EventArgs e)
        {
            var source = (ToolStripMenuItem)sender;
            var p = (ContextMenuStrip)source.Owner;
            UIService.ExpandAll(((TreeView)p.SourceControl).SelectedNode);
        }

        private void menuCollapseAllGeneric_Click(object sender, EventArgs e)
        {
            var source = (ToolStripMenuItem)sender;
            var p = (ContextMenuStrip)source.Owner;
            UIService.CollapseAll(((TreeView)p.SourceControl).SelectedNode);
        }

        private void menuDestinationGenerateXML_Click(object sender, EventArgs e)
        {
            var node = treeDestinationSchema.SelectedNode;
            if(node.Tag == null || !node.Tag.ToString().StartsWith("XML_ELEMENT"))
            {
                MessageBox.Show("Can only generate XML from element");
                return;
            }
            var xml = XmlService.PrettyPrint(UIService.GenerateXml(node), false);
            Clipboard.SetText(xml);
        }

        private void menuEditorInsertValueOf_Click(object sender, EventArgs e)
        {
            InsertText("<xsl:value-of select=\"\" />");
        }
        private void InsertText(string text)
        {
            if (textSelected)
            {
                var selection = selectionManager.SelectionCollection.First();
                document.Replace(selection.Offset, selection.Length, text);
            }
            else
            {
                document.Insert(xslEditor.ActiveTextAreaControl.Caret.Offset, text);
            }
            try
            {
                ApplyPrettyPrint();
            }
            catch (Exception) { }
        }

        private void menuEditorApplyPrettyPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ApplyPrettyPrint();
            }
            catch (Exception ex)
            {
                var err = ex.Message;
                while ((ex = ex.InnerException) != null)
                    err += Environment.NewLine + ex.Message;
                MessageBox.Show("Unable to apply pretty print: " + err);
            }
        }

        private void ApplyPrettyPrint()
        {
            xslEditor.Text = XmlService.PrettyPrint(xslEditor.Text);
            xslEditor.Refresh();
        }

        private void menuEditorInsertTemplate_Click(object sender, EventArgs e)
        {
            var insert = GetSelectedText();
            InsertText("<xsl:template match=\"\">" + insert + "</xsl:template>");
        }

        private string GetSelectedText()
        {
            var insert = "";
            if (textSelected)
            {
                var selection = selectionManager.SelectionCollection.First();
                insert = selection.SelectedText;
            }
            return insert;
        }

        private void menuEditorInsertValueOfApplyTemplate_Click(object sender, EventArgs e)
        {
            InsertText("<xsl:apply-templates select=\"\" />");
        }

        private void menuEditorInsertIf_Click(object sender, EventArgs e)
        {
            var insert = GetSelectedText();
            InsertText("<xsl:if test=\"\">" + insert + "</xsl:if>");
        }

        private void menuEditorInsertChoose_Click(object sender, EventArgs e)
        {
            var insert = GetSelectedText();
            InsertText(@"<xsl:choose>
<xsl:when test="""">" + insert + @"</xsl:when>
<xsl:otherwise></xsl:otherwise>
</xsl:choose>");
        }
    }
}
