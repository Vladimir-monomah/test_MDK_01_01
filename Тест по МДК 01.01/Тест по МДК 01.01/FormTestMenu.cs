using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_по_МДК_01._01
{
    public partial class FormTestMenu : Form
    {
        public FormTestMenu()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?", "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"«Система ткстирования» была создана
фирмой по программрованию в компьютерных системах «Луч»
специалистом по IT-технологиям и программированию, Быковым Владимиром Олеговичем");
        }

        private void ProgrammMenu_Click(object sender, EventArgs e)
        {
            Process.Start("о программе.chm");
        }

        private void MenuStart_Click(object sender, EventArgs e)
        {
            Тест открыть = new Тест();
            открыть.ShowDialog();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            БД_тестирующихся открыть = new БД_тестирующихся();
            открыть.ShowDialog();
        }
    }
}
