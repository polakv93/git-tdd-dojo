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
            Result += v;
        }
    }
}
