using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Тест_по_МДК_01._01
{
    public partial class Тест : Form
    {
        public Тест()
        {
            InitializeComponent();
        }

        double cl;

        private void button1_Click(object sender, EventArgs e)
        {
            var currentUser = new UserInfo
            {
                UserName = userNameTextBox.Text,
                UserGroup = groupNumericUpDown1.Value
            };
            Тестирование_по_МДК_01 открыть = new Тестирование_по_МДК_01(currentUser);
            открыть.ShowDialog();
        }

        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void groupNumericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            groupNumericUpDown1.Text = groupNumericUpDown1.Text.TrimStart('0');
        }
    }
}
