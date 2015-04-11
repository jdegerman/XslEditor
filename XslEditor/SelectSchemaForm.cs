using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XslEditor
{
    public partial class SelectSchemaForm : Form
    {
        public bool InstanceMandatory { get; set; }
        public string XmlSchema { get; private set; }
        public string XmlInstance { get; private set; }
        public SelectSchemaForm(bool instanceMandatory, string schema, string instance)
        {
            InitializeComponent();
            InstanceMandatory = instanceMandatory;
            groupBox2.Text += !instanceMandatory ? " (Optional)" : "";
            if (!string.IsNullOrEmpty(schema))
                txtSchemaPath.Text = schema;
            if (!string.IsNullOrEmpty(instance))
                txtInstancePath.Text = instance;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string error = null;
            if((InstanceMandatory && !File.Exists(txtInstancePath.Text)) || (File.Exists(txtInstancePath.Text) && !XmlService.ValidateXml(txtInstancePath.Text, ref error)))
            {
                var message = "You must specify a valid XML instance.";
                if (!string.IsNullOrEmpty(error))
                    message += Environment.NewLine + Environment.NewLine + "Additional information: " + error;
                MessageBox.Show(message, "Error");
                return;
            }
            if (!File.Exists(txtSchemaPath.Text) || (File.Exists(txtSchemaPath.Text) && !XmlService.ValidateXml(txtSchemaPath.Text, ref error)))
            {
                var message = "You must specify a valid XML schema.";
                if (!string.IsNullOrEmpty(error))
                    message += Environment.NewLine + Environment.NewLine + "Additional information: " + error;
                MessageBox.Show(message, "Error");
                return;
            }
            XmlSchema = txtSchemaPath.Text;
            XmlInstance = txtInstancePath.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnBrowseSchema_Click(object sender, EventArgs e)
        {
            UIService.OpenFile("XML schema (*.xsd)|*.xsd", file => txtSchemaPath.Text = file);
        }

        private void btnBrowseInstance_Click(object sender, EventArgs e)
        {
            UIService.OpenFile("XML instance (*.xml)|*.xml", file => txtInstancePath.Text = file);
        }
    }
}
