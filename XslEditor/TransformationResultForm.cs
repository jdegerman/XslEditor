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
    public partial class TransformationResultForm : Form
    {
        public void SetText(string text)
        {
            xslResult.Text = text;
            xslResult.Refresh();
            xslResult.ActiveTextAreaControl.Refresh();
        }
        public TransformationResultForm()
        {
            InitializeComponent();
            xslResult.IsReadOnly = true;
        }

        private void TransformationResultForm_Load(object sender, EventArgs e)
        {

        }

        private void TransformationResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
        }
    }
}
