using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SpaceStation14_HoPBase.Data;

namespace SpaceStation14_HoPBase.Service
{
    public static class XMLService
    {
        public static bool CreateBase()
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() != DialogResult.OK) { return false; }
            if (File.Exists(folder.SelectedPath + "\\HopBase.xml"))
            {
                MessageBox.Show("Файл уже существует", "Ошибка создания", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            XDocument xdoc = new XDocument();
            XElement main = new XElement("HopBase");
            xdoc.Add(main);
            xdoc.Save(folder.SelectedPath + "\\HopBase.xml");
            SaveLoadService.FileName = folder.SelectedPath + "\\HopBase.xml";
            SaveLoadService.Status = BaseStatus.Saved;
            return true;
        }
        public static bool LoadBase()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XML base|*.xml";
            file.Multiselect = false;
            if (file.ShowDialog() != DialogResult.OK) { return false; }
            if (!File.Exists(file.FileName))
            {
                MessageBox.Show("Файл не найден", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            XDocument xdoc = XDocument.Load(file.FileName);
            XElement main = xdoc.Root;
            SaveLoadService.players.Clear();
            foreach (XElement i in main.Elements())
            {
                Player p = new Player(i.Element("Name").Value, i.Element("Jobs").Value, i.Element("Other").Value);
                SaveLoadService.players.Add(p);
            }
            SaveLoadService.FileName = file.FileName;
            SaveLoadService.Status = BaseStatus.Saved;
            return true;
        }
        public static void UpdateBase()
        {
            XDocument xdoc = XDocument.Load(SaveLoadService.FileName);
            xdoc.Root.RemoveAll();
            XElement main = xdoc.Root;
            foreach (Player i in SaveLoadService.players)
            {
                XElement obj = new XElement("Player");
                obj.Add(new XElement("Name", i.Name));
                obj.Add(new XElement("Jobs", i.Jobs));
                obj.Add(new XElement("Other", i.Other));
                main.Add(obj);
            }
            xdoc.Save(SaveLoadService.FileName);
            SaveLoadService.Status = BaseStatus.Saved;
        }
    }
}
