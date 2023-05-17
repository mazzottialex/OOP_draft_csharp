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
        private List<Modulo> _listModuli=new List<Modulo>();
        public Form2()
        {

            InitializeComponent();

            
            InitializeRadioButton();
        }

        private void InitializeRadioButton()
        {
            _listModuli.AddRange(new List<Modulo> { new Modulo(5, 3, 2),
                new Modulo(5, 2, 3),
                new Modulo(4, 5, 1),
                new Modulo(4, 4, 2),
                new Modulo(4, 3, 3),
                new Modulo(3, 5, 2),
                new Modulo(3, 4, 3),
            });
            int i = 0;
            foreach (Modulo mod in _listModuli)
            {
                Console.WriteLine(_listModuli.Take(0).ToString());
                i += 25;
                RadioButton rb = new RadioButton();
                rb.Text = mod.ToString();
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
                    LogicsFile file = new LogicsFile();
                    Console.WriteLine(radio.Text);
                }
            }
        }
    }
}
