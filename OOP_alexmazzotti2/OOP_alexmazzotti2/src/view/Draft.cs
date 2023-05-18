using OOP_alexmazzotti2.src.view;
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
        private List<Calciatore> _li = new List<Calciatore>();
        private Dictionary<Button, int> _dic = new Dictionary<Button, int>();
        public Draft(Modulo mod)
        {
            _mod = mod;
            _log = new LogicsForm3Impl();
            _li = _log.GetList(mod);
            InitializeComponent();
            InitializeButton();          
            //Console.WriteLine(_log.GetList(_mod)[0]);
        }

        private void InitializeButton()
        {
            List<int> moduloLi = _mod.GetList();
            Console.WriteLine(moduloLi.ToString());
            moduloLi.Reverse();
            int i = 0;
            int n = 0;
            foreach(int val in moduloLi)
            {
                for (int j = 0; j < val; j++)
                {
                    Button btn = new Button();
                    _dic.Add(btn, n);
                    btn.Click += Btn_Click;
                    btn.Text = "Scegli";
                    tableLayoutPanel1.Controls.Add(btn, 6 - val + j * 2, i);
                    n++;
                }
                i++;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int i = _dic[(Button)sender];
            Console.WriteLine(i.ToString());
            DialogCalciatori form = new DialogCalciatori(_li.GetRange(i*5, 5));
            form.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
