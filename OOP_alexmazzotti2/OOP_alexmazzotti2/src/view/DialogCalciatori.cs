using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_alexmazzotti2.src.view
{
    public partial class DialogCalciatori : Form
    {
        private List<Calciatore> _li=new List<Calciatore>();
        public DialogCalciatori(List<Calciatore> li)
        {
            _li = li;
            InitializeComponent();
            InitializePanel();
        }

        private void InitializePanel()
        {
            int i = 0;
            foreach(Calciatore c in _li)
            {
                Console.WriteLine(c.ToString());
                i++;
                Button btn = new Button();
                //btn.Click += Btn_Click;
                btn.Text = c.ToString();
                tableLayoutPanel1.Controls.Add(btn, i, 0);
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
