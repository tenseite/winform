using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsApp_UserInterface
{
    class Class_Task1 : IEvaluate
    {
        // номер варианта 
        public int NumOfVariant { get; set; }
        private int paramValue;

        // параметрическое значение (n) 
        public int GetParamValue()
        {
            return paramValue;
        }

        public void SetParamValue(int value)
        {
            paramValue = value;
        }

        // назначить номер варианта и значение n по‐умолчанию 
        public void Invoke_Variant(int numOfVariant, int paramValueDefault)
        {
            NumOfVariant = numOfVariant; // задаем номер варианта 
            SetParamValue(paramValueDefault); // задаем значение параметра n 
        }
        public string Execute_Variant() // выполняем задание 2 ////////////////////////// 
        {
            string str_paramValue = GetParamValue().ToString(); // переводим параметр в строку 
            int count = str_paramValue.Length; // подсчитываем число символов в строке 

            string str = String.Format("В числе {0} символов", count);
            return str; // возвращаем получившуюся строку 
        } /////////////////////////////////////////////////////////////////////////////// 
    }
}