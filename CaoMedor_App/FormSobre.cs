using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CaoMedor_App
{
    public partial class FormSobre : MetroForm
    {
        public FormSobre()
        {
            InitializeComponent();
        }

        private void btFecharSobre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
