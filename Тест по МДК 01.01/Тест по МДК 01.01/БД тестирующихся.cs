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
    public partial class БД_тестирующихся : Form
    {
        public БД_тестирующихся()
        {
            InitializeComponent();
        }

        private void БД_тестирующихся_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testiruyuschiesya1DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.testiruyuschiesya1DataSet.Студенты);

        }
    }
}
