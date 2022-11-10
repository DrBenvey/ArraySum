using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArraySumLibrary
{
    public class ArraySumTest
    {
        ArraySumCalc arraySumCalc =new  ArraySumCalc();
        public void TestSpeed(int _N, OperationType? operationType = null)
        {
            if (operationType.HasValue)
            {
                switch (operationType.Value)
                {
                    case OperationType.SumArrayElements:
                        SumArrayElementsTestSpeed(_N);
                        return;
                    //todo other possible operations
                    default:
                        return;
                }
            }
            else
            {
                SumArrayElementsTestSpeed(_N);
                //todo other possible operations
            }
        }
        public string SumArrayElementsTestSpeed(int _N, int _a = -2, int _b = 3)
        {
            string info;
            try
            {
                string Output = $"{Int64.MaxValue} Максимально возможный результат" + "\n";
                //резултат тестирования
                bool Res = true;
                //массив псевдослучайных чисел для тестирования
                int[] input = new int[_N];
                //массив результатов
                Int64?[] output = new Int64?[4];
                //todo использовать нормальный генератор случайных чисел
                //а не дефолтный
                Random r = new Random();
                for (int i = 0; i < _N; i++)
                {
                    input[i] = r.Next(_a, _b);
                }
                //вычисление           
                foreach (ArraySumType arraySumType in Enum.GetValues(typeof(ArraySumType)))
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    output[(int)arraySumType] = arraySumCalc.SumArrayElements(arraySumType, input);
                    stopwatch.Stop();
                    info = $"{output[(int)arraySumType]} {arraySumType} finished in {stopwatch.ElapsedMilliseconds} Milliseconds";
                    Log.Information(info);
                    Output = Output + info + "\n";
                }

                //сверка
                for (int i = 0; i < 4; i++)
                {
                    if (!output[i].HasValue)
                    {
                        info = "Value is null";
                        Log.Error(info);
                        Output = Output + info;
                        return Output;
                    }
                    else
                    {
                        if (i > 0)
                        {
                            if (output[i].Value != output[i - 1].Value)
                            {
                                info = "Values are not equal";
                                Log.Error(info);
                                Res = false;
                                Output = Output + info;
                                return Output;
                            }
                        }
                    }
                }
                if (Res)
                {
                    info = "Evrething is OK";
                    Log.Information(info);
                    Output = Output + info;
                    return Output;
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "SumTestSpeed");
                return ex.ToString();
            }

        }
    }
}
