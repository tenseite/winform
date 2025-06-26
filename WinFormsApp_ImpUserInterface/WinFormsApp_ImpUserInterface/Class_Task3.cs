using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsApp_UserInterface
{
    class Class_Task3 : IEvaluate
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
        public string Execute_Variant() // выполняем задание 3 ////////////////////////// 
        {
            double sum = 0; // накопительная сумма изначально нулевая 
            for (int i = 0; i < GetParamValue(); i++) // считаем по формуле 
            {
                sum += 1 / (Math.Pow(2, i));
            }
            double error = Math.Abs(sum - GetParamValue()) / (GetParamValue() * 100);// считаем погрешность расчетов 

            string str = String.Format("Результат расчета текущего значения: {0:0.0000}\nТочное значение составляет { 1:0.0000}\nПогрешность расчетов: { 2:0.00}% ", 
                 sum, 2, error);
            return str; // возвращаем получившуюся строку 
        } /////////////////////////////////////////////////////////////////////////////// 
    }
}

