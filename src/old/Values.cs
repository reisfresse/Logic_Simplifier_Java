namespace LogicSimplifier
{
    public class ValueDuo
    {
        public int A { get; set; }
        public int B { get; set; }
        public int CrossSum { get; set; }
        public string Debug { get; set; }

        public ValueDuo()
        { }

        public ValueDuo(int aIn, int bIn)
        {
            A = aIn; if (A != 0) CrossSum += 1;
            B = bIn; if (B != 0) CrossSum += 1;
            Debug = A + "" + B;
        }

        public ValueDuo(int[] In)
        {
            A = In[0]; if (A != 0) CrossSum += 1;
            B = In[1]; if (B != 0) CrossSum += 1;
            Debug = A + "" + B;
        }

        public int Cs(ValueDuo v)
        {
            var cs = 0;
            if (v.A != 0) cs += 1;
            if (v.B != 0) cs += 1;
            return cs;
        }
    }

    public class ValueTrio
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int CrossSum { get; set; }
        public string Debug { get; set; }

        public ValueTrio()
        { }

        public ValueTrio(int aIn, int bIn, int cIn)
        {
            A = aIn; if (A != 0) CrossSum += 1;
            B = bIn; if (B != 0) CrossSum += 1;
            C = cIn; if (C != 0) CrossSum += 1;
            Debug = A + "" + B + "" + C;
        }

        public ValueTrio(int[] In)
        {
            A = In[0]; if (A != 0) CrossSum += 1;
            B = In[1]; if (B != 0) CrossSum += 1;
            C = In[2]; if (C != 0) CrossSum += 1;
            Debug = A + "" + B + "" + C;
        }

        public static int Cs(ValueTrio v)
        {
            var cs = 0;
            if (v.A != 0) cs += 1;
            if (v.B != 0) cs += 1;
            if (v.C != 0) cs += 1;
            return cs;
        }
    }

    public class ValueQuartett
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int CrossSum { get; set; }

        public ValueQuartett()
        { }

        public ValueQuartett(int aIn, int bIn, int cIn, int dIn)
        {
            A = aIn; if (A == 1) CrossSum += 1;
            B = bIn; if (B == 1) CrossSum += 1;
            C = cIn; if (C == 1) CrossSum += 1;
            D = dIn; if (D == 1) CrossSum += 1;
        }

        public ValueQuartett(int[] In)
        {
            A = In[0]; if (A == 1) CrossSum += 1;
            B = In[1]; if (B == 1) CrossSum += 1;
            C = In[2]; if (C == 1) CrossSum += 1;
            D = In[3]; if (D == 1) CrossSum += 1;
        }

        public static int Cs(ValueQuartett v)
        {
            var cs = 0;
            if (v.A != 0) cs += 1;
            if (v.B != 0) cs += 1;
            if (v.C != 0) cs += 1;
            if (v.D != 0) cs += 1;
            return cs;
        }
    }

    public class ValueQuintett
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int CrossSum { get; set; }

        public ValueQuintett()
        { }

        public ValueQuintett(int aIn, int bIn, int cIn, int dIn, int eIn)
        {
            A = aIn; if (A == 1) CrossSum += 1;
            B = bIn; if (B == 1) CrossSum += 1;
            C = cIn; if (C == 1) CrossSum += 1;
            D = dIn; if (D == 1) CrossSum += 1;
            E = eIn; if (E == 1) CrossSum += 1;
        }

        public ValueQuintett(int[] In)
        {
            A = In[0]; if (A == 1) CrossSum += 1;
            B = In[1]; if (B == 1) CrossSum += 1;
            C = In[2]; if (C == 1) CrossSum += 1;
            D = In[3]; if (D == 1) CrossSum += 1;
            E = In[4]; if (E == 1) CrossSum += 1;
        }
    }

    public class ValueSextett
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int E { get; set; }
        public int F { get; set; }
        public int CrossSum { get; set; }

        public ValueSextett()
        { }

        public ValueSextett(int aIn, int bIn, int cIn, int dIn, int eIn, int fIn)
        {
            A = aIn; if (A == 1) CrossSum += 1;
            B = bIn; if (B == 1) CrossSum += 1;
            C = cIn; if (C == 1) CrossSum += 1;
            D = dIn; if (D == 1) CrossSum += 1;
            E = eIn; if (E == 1) CrossSum += 1;
            F = fIn; if (F == 1) CrossSum += 1;
        }

        public ValueSextett(int[] In)
        {
            A = In[0]; if (A == 1) CrossSum += 1;
            B = In[1]; if (B == 1) CrossSum += 1;
            C = In[2]; if (C == 1) CrossSum += 1;
            D = In[3]; if (D == 1) CrossSum += 1;
            E = In[4]; if (E == 1) CrossSum += 1;
            F = In[5]; if (F == 1) CrossSum += 1;
        }
    }
}