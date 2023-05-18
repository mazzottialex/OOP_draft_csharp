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
    public partial class DialogModulo : Form
    {
        private IDictionary<RadioButton, Modulo> _dic = new Dictionary<RadioButton, Modulo>();
        private List<Modulo> _listModuli = new List<Modulo> { new Modulo(5, 3, 2),
                new Modulo(5, 2, 3),
                new Modulo(4, 5, 1),
                new Modulo(4, 4, 2),
                new Modulo(4, 3, 3),
                new Modulo(3, 5, 2),
                new Modulo(3, 4, 3),
            };
        private Modulo _modS;

        public DialogModulo()
        {
            InitializeComponent();
            InitializeRadioButton();
        }

        private void InitializeRadioButton()
        {
            int i = 0;
            foreach (Modulo mod in _listModuli)
            {
                i += 25;
                RadioButton rb = new RadioButton();
                rb.Text = mod.ToString();
                
                rb.Location = new System.Drawing.Point(220, 40 + i);
                _dic.Add(rb, mod);
                Controls.Add(rb);
            }
        }

        public Modulo GetModuloSelezionato()
        {
            return _modS;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (RadioButton radio in _dic.Keys)
            {
                if (radio.Checked)
                {
                    Modulo modSelezionato = _dic[radio];
                    _modS = _dic[radio];
                    Close();
                }
            }
        }

    }
}
