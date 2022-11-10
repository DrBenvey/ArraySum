using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumLibrary
{
    #region вспомогательные истории
    public enum ArraySumType
    {
        plain,
        linq,
        vectors,
        intrinsics
    }

    public enum OperationType
    {
        SumArrayElements
        //todo other possible operations sum two arrays for exmple
    }
    #endregion

    /// <summary>
    /// класс для сложение элементов массива
    /// взято и переработано из https://habr.com/en/post/435840/
    /// </summary>
    public class ArraySumCalc
    {
        public Int64? SumArrayElements(ArraySumType _arraySumType, int[] _input)
        {
            switch (_arraySumType)
            {
                case ArraySumType.plain:
                    return PlainSumElements(_input);
                case ArraySumType.linq:
                    return LinqSumElements(_input);
                case ArraySumType.vectors:
                    return VectorsSumElements(_input);
                case ArraySumType.intrinsics:
                    return IntrinsicsSumElements(_input);
                default:
                    return null;
            }
        }

        #region SumElements
        private Int64? PlainSumElements(int[] _input)
        {
            try
            {
                Int64 res = 0;
                foreach (int i in _input)
                {
                    try
                    {
                        checked
                        {
                            res = res + i;
                        }
                    }
                    catch (OverflowException ex)
                    {
                        Log.Error(ex, "PlainSumElements");
                        return null;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "PlainSumElements");
                return null;
            }

        }

        private Int64? LinqSumElements(int[] _input)
        {
            try
            {
                try
                {
                    checked
                    {
                        return _input.Aggregate<int, Int64>(0, (current, i) => current + i);
                    }
                }
                catch (OverflowException ex)
                {
                    Log.Error(ex, "VectorsSumElements");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "LinqSumElements");
                return null;
            }
        }

        private Int64? VectorsSumElements(int[] _input)
        {
            try
            {
                int vectorSize = Vector<int>.Count;
                var accVector = Vector<int>.Zero;
                int i;
                var array = _input;
                for (i = 0; i < array.Length - vectorSize; i += vectorSize)
                {
                    var v = new Vector<int>(array, i);
                    accVector = Vector.Add(accVector, v);
                }
                Int64 result = 0;
                try
                {
                    checked
                    {
                        result = Vector.Dot(accVector, Vector<int>.One);
                    }
                }
                catch (OverflowException ex)
                {
                    Log.Error(ex, "VectorsSumElements");
                    return null;
                }

                for (; i < array.Length; i++)
                {
                    try
                    {
                        checked
                        {
                            result = result + array[i];
                        }
                    }
                    catch (OverflowException ex)
                    {
                        Log.Error(ex, "VectorsSumElements");
                        return null;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "VectorsSumElements");
                return null;
            }
        }

        public unsafe Int64? IntrinsicsSumElements(int[] _input)
        {
            try
            {
                int vectorSize = 256 / 8 / 4;
                var accVector = Vector256<int>.Zero;
                int i;
                var array = _input;
                fixed (int* ptr = array)
                {
                    for (i = 0; i < array.Length - vectorSize; i += vectorSize)
                    {
                        var v = Avx2.LoadVector256(ptr + i);
                        accVector = Avx2.Add(accVector, v);
                    }
                }
                Int64 result = 0;
                var temp = stackalloc int[vectorSize];
                Avx2.Store(temp, accVector);
                for (int j = 0; j < vectorSize; j++)
                {
                    try
                    {
                        checked
                        {
                            result += temp[j];
                        }
                    }
                    catch (OverflowException ex)
                    {
                        Log.Error(ex, "IntrinsicsSumElements");
                        return null;
                    }
                }
                for (; i < array.Length; i++)
                {
                    try
                    {
                        checked
                        {
                            result = result + array[i];
                        }
                    }
                    catch (OverflowException ex)
                    {
                        Log.Error(ex, "IntrinsicsSumElements");
                        return null;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "IntrinsicsSumElements");
                return null;
            }

        }
        #endregion
    }
}
