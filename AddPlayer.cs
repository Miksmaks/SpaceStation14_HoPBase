using SpaceStation14_HoPBase.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStation14_HoPBase
{
    public partial class AddPlayer : Form
    {
        bool done = false;
        public AddPlayer()
        {
            InitializeComponent();
        }

        public bool GetDone() { return done; }

        private void AddLine(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") 
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveLoadService.players.Add(new Data.Player(textBox2.Text, textBox3.Text, textBox4.Text));
            done = true;
            Close();
        }
    }
}
