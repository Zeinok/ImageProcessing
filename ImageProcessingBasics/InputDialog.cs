using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingBasics
{
    public partial class InputDialog : Form
    {
        public InputDialog()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        public Type Type { get; set; }
        public object Result { get; private set; }
        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            validateInput();
        }

        private void validateInput()
        {
            buttonOK.Enabled = true;
            try
            {
                TypeConverter tc = TypeDescriptor.GetConverter(Type);
                try
                {
                    Result = tc.ConvertFrom(textBox.Text);
                }
                catch
                {
                    buttonOK.Enabled = false;
                }
            }
            catch { };
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                buttonOK.PerformClick();
            }
        }
    }
}
