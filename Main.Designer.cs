namespace SpaceStation14_HoPBase
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HoPContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreatePlayerTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePlayerTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateBaseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadBaseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBaseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HoPContext.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 404);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ItemSelect);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.textBox2.Location = new System.Drawing.Point(309, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.label1.Location = new System.Drawing.Point(305, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.label2.Location = new System.Drawing.Point(305, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Профессии";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.textBox3.Location = new System.Drawing.Point(309, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(327, 26);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.label3.Location = new System.Drawing.Point(305, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дополнительно";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.textBox4.Location = new System.Drawing.Point(309, 191);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(327, 277);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.button1.Location = new System.Drawing.Point(414, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditPlayer);
            // 
            // HoPContext
            // 
            this.HoPContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatePlayerTSMI,
            this.DeletePlayerTSMI});
            this.HoPContext.Name = "HoPContext";
            this.HoPContext.Size = new System.Drawing.Size(168, 48);
            // 
            // CreatePlayerTSMI
            // 
            this.CreatePlayerTSMI.Name = "CreatePlayerTSMI";
            this.CreatePlayerTSMI.Size = new System.Drawing.Size(167, 22);
            this.CreatePlayerTSMI.Text = "Добавить игрока";
            this.CreatePlayerTSMI.Click += new System.EventHandler(this.AddPlayer);
            // 
            // DeletePlayerTSMI
            // 
            this.DeletePlayerTSMI.Name = "DeletePlayerTSMI";
            this.DeletePlayerTSMI.Size = new System.Drawing.Size(167, 22);
            this.DeletePlayerTSMI.Text = "Удалить игрока";
            this.DeletePlayerTSMI.Click += new System.EventHandler(this.RemovePlayer);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateBaseTSMI,
            this.LoadBaseTSMI,
            this.SaveBaseTSMI});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateBaseTSMI
            // 
            this.CreateBaseTSMI.Name = "CreateBaseTSMI";
            this.CreateBaseTSMI.Size = new System.Drawing.Size(180, 22);
            this.CreateBaseTSMI.Text = "Создать базу";
            this.CreateBaseTSMI.Click += new System.EventHandler(this.CreateBase);
            // 
            // LoadBaseTSMI
            // 
            this.LoadBaseTSMI.Name = "LoadBaseTSMI";
            this.LoadBaseTSMI.Size = new System.Drawing.Size(180, 22);
            this.LoadBaseTSMI.Text = "Загрузить базу";
            this.LoadBaseTSMI.Click += new System.EventHandler(this.LoadBase);
            // 
            // SaveBaseTSMI
            // 
            this.SaveBaseTSMI.Name = "SaveBaseTSMI";
            this.SaveBaseTSMI.Size = new System.Drawing.Size(180, 22);
            this.SaveBaseTSMI.Text = "Сохранить базу";
            this.SaveBaseTSMI.Click += new System.EventHandler(this.SaveBase);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 480);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "HoPBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.HoPContext.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip HoPContext;
        private System.Windows.Forms.ToolStripMenuItem CreatePlayerTSMI;
        private System.Windows.Forms.ToolStripMenuItem DeletePlayerTSMI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateBaseTSMI;
        private System.Windows.Forms.ToolStripMenuItem LoadBaseTSMI;
        private System.Windows.Forms.ToolStripMenuItem SaveBaseTSMI;
    }
}

