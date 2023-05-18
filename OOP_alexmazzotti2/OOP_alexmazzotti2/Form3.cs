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
    public partial class Form3 : Form
    {
        private ILogicsForm3 _log;
        private Modulo _mod;
        public Form3(Modulo mod)
        {
            _mod = mod;
            InitializeComponent();
            InitializeButton();          
            _log = new LogicsForm3Impl();
            Console.WriteLine(_log.GetList(new Modulo(4, 3, 3))[0]);
        }

        private void InitializeButton()
        {
            List<int> moduloLi = _mod.GetList();
            Console.WriteLine(moduloLi.ToString());
            moduloLi.Reverse();
            int i = 0;
            foreach(int val in moduloLi)
            {
                
                for (int j = 0; j < val; j++)
                {
                    Button btn = new Button();
                    btn.Text = "Scegli";
                    tableLayoutPanel1.Controls.Add(btn, 6 - val + j * 2, i);
                }
                i++;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
