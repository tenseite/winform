using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
namespace WinFormsApp_UserInterface
{
    interface IEvaluate // интерфейс для вычисления 
    {
        int NumOfVariant { get; set; } // номер варианта 
                                     // назначить номер варианта и значение n по‐умолчанию 
        void Invoke_Variant(int numOfVariant, int EvaluateValueDefault);
        // выполнить задание 
        string Execute_Variant();
        void SetParamValue(int v);
    }
}
