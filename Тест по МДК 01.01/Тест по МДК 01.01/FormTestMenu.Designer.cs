namespace Тест_по_МДК_01._01
{
    partial class FormTestMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestMenu));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.StartTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgrammMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartTest,
            this.базаДанныхToolStripMenuItem,
            this.справкаMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(516, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // StartTest
            // 
            this.StartTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStart,
            this.toolStripMenuItem1,
            this.Close});
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(83, 20);
            this.StartTest.Text = "Начать тест";
            // 
            // MenuStart
            // 
            this.MenuStart.Name = "MenuStart";
            this.MenuStart.Size = new System.Drawing.Size(130, 22);
            this.MenuStart.Text = "МДК 01.01";
            this.MenuStart.Click += new System.EventHandler(this.MenuStart_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(130, 22);
            this.Close.Text = "Закрыть";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // справкаMenu
            // 
            this.справкаMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgrammMenu,
            this.AboutMenu});
            this.справкаMenu.Name = "справкаMenu";
            this.справкаMenu.Size = new System.Drawing.Size(65, 20);
            this.справкаMenu.Text = "Справка";
            // 
            // ProgrammMenu
            // 
            this.ProgrammMenu.Name = "ProgrammMenu";
            this.ProgrammMenu.Size = new System.Drawing.Size(162, 22);
            this.ProgrammMenu.Text = "О программе";
            this.ProgrammMenu.Click += new System.EventHandler(this.ProgrammMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(162, 22);
            this.AboutMenu.Text = "О разработчике";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // FormTestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 381);
            this.ControlBox = false;
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTestMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem StartTest;
        private System.Windows.Forms.ToolStripMenuItem MenuStart;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem справкаMenu;
        private System.Windows.Forms.ToolStripMenuItem ProgrammMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}

