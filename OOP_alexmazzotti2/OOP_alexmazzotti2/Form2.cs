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
    public partial class Form2 : Form
    {
        private List<RadioButton> _listRadio=new List<RadioButton>();
        public Form2()
        {
            InitializeComponent();
            InitializeRadioButton();
        }

        private void InitializeRadioButton()
        {
            int i = 0;
            foreach (moduli mod in Enum.GetValues(typeof(moduli)))
            {
                i += 25;
                RadioButton rb = new RadioButton();
                rb.Text=mod.ToString();
                rb.Location = new System.Drawing.Point(280, 120 + i);
                _listRadio.Add(rb);
                Controls.Add(rb);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (RadioButton radio in _listRadio)
            {
                if (radio.Checked)
                {
                    Console.WriteLine(radio.Text);
                }
            }
        }
    }
}
