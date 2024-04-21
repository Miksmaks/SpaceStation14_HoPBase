using SpaceStation14_HoPBase.Data;
using SpaceStation14_HoPBase.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpaceStation14_HoPBase
{
    public partial class Main : Form
    {
        int IdSelectPlayer;
        public Main()
        {
            InitializeComponent();
            listBox1.ContextMenuStrip = HoPContext;
        }

        private void UpdateTable()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < SaveLoadService.players.Count; i++)
            {
                listBox1.Items.Add(SaveLoadService.players[i].Name);
            }
        }

        private void CreateBase(object sender, EventArgs e)
        {
            if (SaveLoadService.Status == BaseStatus.Edit)
            {
                DialogResult obj = MessageBox.Show("Текущая база не сохранена. Создать новую?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (obj == DialogResult.No) { return; }
                XMLService.CreateBase();
                UpdateTable();
            }
            else
            {
                if (!XMLService.CreateBase()) { return; }
                listBox1.Enabled = true;
                button1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                UpdateTable();
            }
        }

        private void LoadBase(object sender, EventArgs e)
        {
            if (SaveLoadService.Status == BaseStatus.Edit)
            {
                DialogResult obj = MessageBox.Show("Текущая база не сохранена. Загрузить новую?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (obj == DialogResult.No) { return; }
                XMLService.LoadBase();
                UpdateTable();
            }
            else
            {
                if (!XMLService.LoadBase()) { return; }
                listBox1.Enabled = true;
                button1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                UpdateTable();
            }
        }

        private void SaveBase(object sender, EventArgs e)
        {
            if (SaveLoadService.Status == BaseStatus.Unknown) { return; }
            XMLService.UpdateBase();
            this.Text = "HoPBase";
        }

        private void AddPlayer(object sender, EventArgs e)
        {
            AddPlayer form = new AddPlayer();
            form.ShowDialog();
            if (form.GetDone())
            {
                UpdateTable();
                SaveLoadService.Status = BaseStatus.Edit;
                this.Text = "HoPBase (*)";
            }
        }

        private void RemovePlayer(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) { return; }
            SaveLoadService.players.RemoveAt(IdSelectPlayer);
            UpdateTable();
            SaveLoadService.Status = BaseStatus.Edit;
            this.Text = "HoPBase (*)";
        }

        private void ItemSelect(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex < 0) { return; }
            IdSelectPlayer = listBox1.SelectedIndex;
            Player obj = SaveLoadService.players[IdSelectPlayer];
            textBox2.Text = obj.Name;
            textBox3.Text = obj.Jobs;
            textBox4.Text = obj.Other;
        }

        private void EditPlayer(object sender, MouseEventArgs e)
        {
            if (IdSelectPlayer < 0) { return; }
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveLoadService.players[IdSelectPlayer].Name = textBox2.Text;
            SaveLoadService.players[IdSelectPlayer].Jobs = textBox3.Text;
            SaveLoadService.players[IdSelectPlayer].Other = textBox4.Text;
            UpdateTable();
            SaveLoadService.Status = BaseStatus.Edit;
            this.Text = "HoPBase (*)";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveLoadService.Status == BaseStatus.Edit) 
            {
                DialogResult obj = MessageBox.Show("Текущая база не сохранена. Закрыть?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (obj != DialogResult.Yes) 
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
