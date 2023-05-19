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
        private Dictionary<Button, Calciatore> _dic=new Dictionary<Button, Calciatore>();
        private Calciatore _selezionato=null;
        public DialogCalciatori(List<Calciatore> li)
        {
            _li = li;
            InitializeComponent();
            InitializePanel();
        }

        public Calciatore GetSelezionato()
        {
            return _selezionato;
        }

        private void InitializePanel()
        {
            int i = 0;
            foreach(Calciatore c in _li)
            {
                Console.WriteLine(c.ToString());
                i++;
                Button btn = new Button();
                btn.Click += Btn_Click;
                btn.Text = c.Nome;
                btn.Width = 120;
                btn.Height = 40 ;
                btn.Anchor = AnchorStyles.None;
                btn.BackColor = Color.WhiteSmoke;
                _dic.Add(btn, c);
                tableLayoutPanel1.Controls.Add(btn, i, 0);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach(Button b in _dic.Keys)
            {
                b.BackColor = Color.Transparent;
            }
            btn.BackColor = Color.FromArgb(130,0,130,255);
            _selezionato = _dic[btn];
            btnOk.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
              Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _selezionato = null;
            Close();
        }
    }
}
