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
        public Form3()
        {
            InitializeComponent();
            InitializeButton();
        }

        private void InitializeButton()
        {
            Modulo mod = new Modulo(4, 3, 2);
            List<int> moduloLi = mod.getList();
            Console.WriteLine(moduloLi.ToString());
           // moduloLi.Reverse();
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
