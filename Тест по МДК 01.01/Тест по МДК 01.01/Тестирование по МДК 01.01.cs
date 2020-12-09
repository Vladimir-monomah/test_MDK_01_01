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
    public partial class Тестирование_по_МДК_01 : Form
    {
        private Ans ans = new Ans();

        private int index = -1;

        /// <summary>
        /// Информация о пользователе, выполняющем данный тест
        /// Далее она будет записана в БД
        /// </summary>
        private UserInfo currentUser;

        public Тестирование_по_МДК_01()
        {
            InitializeComponent();

            ans.Question(questionRichTextBox);
            ans.Test(firstradioButton, secondradioButton, thirdradioButton);
            resultLabel.Text = ans.GetCorrect;
        }

        public Тестирование_по_МДК_01(UserInfo currentUser)
            : this()
        {
            this.currentUser = currentUser;
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;

            if (button == firstradioButton) { index = 0; }
            if (button == secondradioButton) { index = 1; }
            if (button == thirdradioButton) { index = 2; }
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            try
            {
                ans.Correct(index, resultLabel);

                firstradioButton.Checked = false;
                secondradioButton.Checked = false;
                thirdradioButton.Checked = false;

                index = -1;
            }
            catch { return; }

            ans.Index++;

            if (ans.Index > 5)
            {
                this.EndTest();
                return;
            }            

            ans.Question(questionRichTextBox);
            ans.Test(firstradioButton, secondradioButton, thirdradioButton);
        }

        private void EndTest()
        {
            var mark = ans.GetMark();

            this.AddStudentTestResult(mark);

            MessageBox.Show("Ваша оценка: " + mark, "Поздравляем!");
            Close();
        }


        private void AddStudentTestResult(string testResult)
        {
            var student = this.testiruyuschiesya1DataSet.Студенты.NewСтудентыRow();
            student.ФИО = this.currentUser.UserName;
            student.номер_группы = Convert.ToInt32(this.currentUser.UserGroup);
            student.Оценка = testResult;

            this.testiruyuschiesya1DataSet.Студенты.AddСтудентыRow(student);

            this.студентыTableAdapter.Adapter.Update(this.testiruyuschiesya1DataSet.Студенты);
        }
    }
}
