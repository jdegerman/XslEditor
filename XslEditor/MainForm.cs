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

        public MainForm()
        {
            InitializeComponent();
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

    }
}
