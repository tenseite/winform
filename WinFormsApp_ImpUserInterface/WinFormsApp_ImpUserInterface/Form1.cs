using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_UserInterface;

namespace WinFormsApp_ImpUserInterface
{
    public partial class Form1 : Form
    {
        private bool _flag_access = true; //###// флаг доступа (по‐умолчанию включен) 
        private readonly int[] _paramValuesDefault = { 10, 9, 8 };  // начальные значения параметров в виде констант
      private IEvaluate[] _evaluate_ref = { null, null, null }; // указатели на вычисляемые данные 
        public Form1()
        {
            InitializeComponent();
            _evaluate_ref[0] = new Class_Task1(); // используем МЕХАНИЗМ ВИРТУАЛИЗАЦИИ 
            _evaluate_ref[1] = new Class_Task2(); // для задач 1, 2, 3 с помощью пользовательского 
            _evaluate_ref[2] = new Class_Task3(); // интерфейса IEvaluate 
            comBox_TaskNum.SelectedIndex = 0; // первоначально индекс устанавливаем в 0 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comBox_TaskNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_flag_access) return; //###// если флаг доступа выключен (false), функция не выполняется


         int ind = comBox_TaskNum.SelectedIndex; // новое значение индекса строки в ComboBox_TaskNum
                     _evaluate_ref[ind].Invoke_Variant(ind, _paramValuesDefault[ind]); // задаем начальные значения


         textBox_InputValue.Text = _paramValuesDefault[ind].ToString(); // присваиваем значение в текстовое окно

            // загружаем ресурс с имененм "Task_" и номер задания 
            pictureBox_Formula.Image = (Image)Properties.Resources.ResourceManager.GetObject("Task_" + (ind + 1).ToString());
        }

        private void buttonEvaluateVariant_Click(object sender, EventArgs e)
        {
            if (!_flag_access) return; //###// если флаг доступа выключен (false), функция невыполняется


         int ind = comBox_TaskNum.SelectedIndex; // текущее значение индекса строки в ComoBox_TaskNum
         string str_out = _evaluate_ref[ind].Execute_Variant(); // вычисляем и получаем строку результатов


         Label_Output.Text = str_out; // выводим строку 
        }

        private void textBox_InputValue_TextChanged(object sender, EventArgs e)
        {
            if (!_flag_access) return; //###// если флаг доступа выключен (false), функция не выполняется


         int ind = comBox_TaskNum.SelectedIndex; // текущее значение индекса строки в ComboBox_TaskNum


         string str_num = textBox_InputValue.Text; // получаем введенное значение параметра  
            _evaluate_ref[ind].SetParamValue(Int32.Parse(str_num)); // в виде целого числа 
        }
    }
}
