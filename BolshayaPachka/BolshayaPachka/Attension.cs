using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolshayaPachka
{
    public partial class Attension : Form
    {
        static private bool isCancel = true;
        private string message;

        public Attension(string message)
        {
            InitializeComponent();
            this.message = message;
        }

        public bool GetAction() {
            return isCancel;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            isCancel = false;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            isCancel = true;
            Close();
        }

        private void Attension_Load(object sender, EventArgs e)
        {
            label2.Text = message;
        }
    }
}
