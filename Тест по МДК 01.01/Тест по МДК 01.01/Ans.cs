using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Тест_по_МДК_01._01
{
    public class Ans
    {
        private List<string> questions = new List<string>()
        {
            "Именованная совокупность данных, отражающая состояние объектов и их отношений в рассматриваемой предметной области данных...",
            "Совокупность языковых и программных средств, предназначенных для создания, ведения и совместного использования БД многими пользователями называют...",
            "Основные функции СУБД...",
            "Модели баз данных...",
            "Значение одного из признаков характеризующих объекты БД...",
            "Конкретное значение соответствующего поля..."
        };

        private List<string> answers = new List<string>()
        {
            "модель",
            "базой данных",
            "описание структуры базы",
            "реляционная",
            "запись",
            "ячейка"
        };

        private List<string> test = new List<string>()
        {
            // 1 вопрос
            "СУБД",
            "модель",
            "система",

            // 2 вопрос
            "СУБД",
            "базой данных",
            "моделью данных",

            // 3 вопрос
            "описание структуры базы",
            "обработка данных",
            "управление данными",

            // 4 вопрос
            "сетевая",
            "реляционная",
            "геометрическая",

            // 5 вопрос
            "поле",
            "ячейка",
            "запись",

            // 6 вопрос
            "ячейка",
            "поле",
            "запись"
        };

       

        private bool[,] boolTest = { { false, true, false }, { false, true, false }, { true, false, false }, { false, true, false }, { false, false, true }, { true, false, false } };

        private int correct = 0;

        public int TestIndex { get; set; }
        public int Index { get; set; }

        internal void Test(RadioButton firstradioButton, RadioButton secondradioButton, RadioButton thirdradioButton)
        {
            int startAnswerIndex = Index * 3;
            firstradioButton.Text = test[startAnswerIndex];
            secondradioButton.Text = test[startAnswerIndex + 1];
            thirdradioButton.Text = test[startAnswerIndex + 2];
        }

        public string GetCorrect { get; set; }

        public void Question(Control control)
        {
            control.Text = questions[Index];
        }

        public void Text(Control control1, Control control2, Control control3, Control control4, Control control5, Control control6)
        {
            control1.Text = test[TestIndex];
            TestIndex++;
            control2.Text = test[TestIndex];
            TestIndex++;
            control3.Text = test[TestIndex];
            TestIndex++;
            control4.Text = test[TestIndex];
            TestIndex++;
            control5.Text = test[TestIndex];
            TestIndex++;
            control6.Text = test[TestIndex];
            TestIndex++;
        }


        public void Correct(int i, Control control)
        {
            if (boolTest.Length > Index)
            {
                if (boolTest[Index, i])
                {
                    MessageBox.Show("Правильно");
                    correct++;
                    GetCorrect = "Правильные ответы: " + correct + " из 6";
                    control.Text = GetCorrect;
                }
                else
                {
                    MessageBox.Show("Не правильно");
                }
            }
            else
            {
                MessageBox.Show("Некорректный номер вопроса");
            }
        }

        public Ans()
        {
            Index = 0;
            TestIndex = 0;

            GetCorrect = "Правильные ответы: 0 из 6";
        }

        public string GetMark()
        {
            switch (correct)
            {
                case 6:
                    return "5";
                    break;
                case 5:
                    return "4";
                    break;
                case 4:
                    return "3";
                    break;
            }
            return "2";
        }
    }
}
