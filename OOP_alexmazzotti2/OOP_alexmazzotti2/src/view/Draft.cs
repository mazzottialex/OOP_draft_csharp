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
    public partial class Draft : Form
    {
        private ILogicsForm3 _log;
        private Modulo _mod;
        private List<Button> liBtn=new List<Button>();
        public Draft(Modulo mod)
        {
            _mod = mod;
            InitializeComponent();
            InitializeButton();          
            _log = new LogicsForm3Impl();
            //Console.WriteLine(_log.GetList(_mod)[0]);
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
                    liBtn.Add(btn);
                    btn.Click += Btn_Click;
                    btn.Text = "Scegli";
                    tableLayoutPanel1.Controls.Add(btn, 6 - val + j * 2, i);
                }
                i++;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("cooaa");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
