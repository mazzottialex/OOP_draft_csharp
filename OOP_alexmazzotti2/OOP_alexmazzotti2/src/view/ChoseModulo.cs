using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_alexmazzotti2
{
    public partial class ChoseModulo : Form
    {
        private Modulo mod;
        public ChoseModulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogModulo form = new DialogModulo();
            form.ShowDialog();
            mod=form.GetModuloSelezionato();
            button1.Visible = false;
            label1.Visible = false;
            lblModulo.Visible = true;
            lblModulo.Text = "Modulo scelto:"+mod.ToString();
            
            button2.Visible=true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Draft form = new Draft(mod);
            form.Show();
            this.Hide();
        }
    }
}
