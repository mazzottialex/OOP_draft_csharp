using OOP_alexmazzotti2.src.logics;
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
        private Modulo _mod;
        private ILogicsModulo _log;
        public ChoseModulo()
        {
            InitializeComponent();
            _log = new LogicsModuloImpl(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogModulo form = new DialogModulo(_log.GetLiModuli());
            form.ShowDialog();
            _mod=form.GetModuloSelezionato();
            button1.Visible = false;
            label1.Visible = false;
            lblModulo.Visible = true;
            lblModulo.Text = "Modulo scelto:" + _mod.ToString();
            
            button2.Visible=true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Draft form = new Draft(_mod);
            form.Show();
            this.Hide();
        }
    }
}
