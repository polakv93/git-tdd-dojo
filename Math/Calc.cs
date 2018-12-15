using System;

namespace Math
{
    public class Calc
    {
        public int Result { get; set; }

        public void SetInitial(int? v)
        {
            Result = v ?? 0;
        }

        public void Add(int v) {
            checked 
            {
                Result += v;
            }
        }

        public void Divide(int v)
        {
            Result /= v;
        }

        public void Exp(int v)
        {
            Result = Math.Pow(Result, v);
        }
    }
}
