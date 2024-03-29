﻿using OOP_alexmazzotti2.src.view;
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
        private ILogicsDraft _log;
        private Modulo _mod;
        private List<Calciatore> _li = new List<Calciatore>();
        private Dictionary<Button, int> _dic = new Dictionary<Button, int>();
        public Draft(Modulo mod)
        {
            _mod = mod;
            _log = new LogicsDraftImpl();
            _li = _log.GetList(mod);
            InitializeComponent();
            InitializeButton();          
            //Console.WriteLine(_log.GetList(_mod)[0]);
        }

        private void InitializeButton()
        {
            List<int> moduloLi = _mod.GetList();
            //Console.WriteLine(moduloLi.ToString());
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
                    btn.Width = 120;
                    btn.Height = 40;
                    btn.Text = "Scegli";
                    btn.BackColor = ColorBtn(i);
                    tableLayoutPanel1.Controls.Add(btn, 6 - val + j * 2, i);
                    n++;
                }
                i++;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int i = _dic[btn];
            Console.WriteLine(i.ToString());
            DialogCalciatori form = new DialogCalciatori(_li.GetRange(i*5, 5));
            form.ShowDialog();
            Calciatore c=form.GetSelezionato();
            _log.AddCalciatore(c);
            if (c != null)
            {
                btn.Text = c.Nome;
                btn.Enabled = false;
            }
            if (_log.isCompleted())
            {
                 btnClose.Visible = true;
            }
        }

        private Color ColorBtn(int i)
        {
            switch (i)
            {
                case 0:
                    return Color.Orange;
                case 1:
                    return Color.Green;
                case 2:
                    return Color.Yellow;
                default:
                    return Color.Red;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
