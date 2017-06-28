package de.lefrisson.reisfresse.logicsimplifier.Other;

/**
 * Created by Admin on 26.06.2017.
 * Edited by Admin on 26.06.2017.
 */
class ValueDuo {
	public int A;
	public int B;
	public int CrossSum;
	
	public ValueDuo() { }
	
	public ValueDuo(int aIn, int bIn) {
		A = aIn;
		if (A != 0) CrossSum += 1;
		B = bIn;
		if (B != 0) CrossSum += 1;
	}
	
	public ValueDuo(int[] In) {
		A = In[0];
		if (A != 0) CrossSum += 1;
		B = In[1];
		if (B != 0) CrossSum += 1;
	}
	
	public int Cs(ValueDuo v) {
		int cs = 0;
		if (v.A != 0) cs += 1;
		if (v.B != 0) cs += 1;
		return cs;
	}
}

class ValueTrio {
	public int A;
	public int B;
	public int C;
	public int CrossSum;
	
	public ValueTrio() { }
	
	public ValueTrio(int aIn, int bIn, int cIn) {
		A = aIn;
		if (A != 0) CrossSum += 1;
		B = bIn;
		if (B != 0) CrossSum += 1;
		C = cIn;
		if (C != 0) CrossSum += 1;
	}
	
	public ValueTrio(int[] In) {
		A = In[0];
		if (A != 0) CrossSum += 1;
		B = In[1];
		if (B != 0) CrossSum += 1;
		C = In[2];
		if (C != 0) CrossSum += 1;
	}
	
	public static int Cs(ValueTrio v) {
		int cs = 0;
		if (v.A != 0) cs += 1;
		if (v.B != 0) cs += 1;
		if (v.C != 0) cs += 1;
		return cs;
	}
}

class ValueQuartett {
	public int A;
	public int B;
	public int C;
	public int D;
	public int CrossSum;
	
	public ValueQuartett() { }
	
	public ValueQuartett(int aIn, int bIn, int cIn, int dIn) {
		A = aIn;
		if (A == 1) CrossSum += 1;
		B = bIn;
		if (B == 1) CrossSum += 1;
		C = cIn;
		if (C == 1) CrossSum += 1;
		D = dIn;
		if (D == 1) CrossSum += 1;
	}
	
	public ValueQuartett(int[] In) {
		A = In[0];
		if (A == 1) CrossSum += 1;
		B = In[1];
		if (B == 1) CrossSum += 1;
		C = In[2];
		if (C == 1) CrossSum += 1;
		D = In[3];
		if (D == 1) CrossSum += 1;
	}
	
	public static int Cs(ValueQuartett v) {
		int cs = 0;
		if (v.A != 0) cs += 1;
		if (v.B != 0) cs += 1;
		if (v.C != 0) cs += 1;
		if (v.D != 0) cs += 1;
		return cs;
	}
}

class ValueQuintett {
	public int A;
	public int B;
	public int C;
	public int D;
	public int E;
	public int CrossSum;
	
	public ValueQuintett() { }
	
	public ValueQuintett(int aIn, int bIn, int cIn, int dIn, int eIn) {
		A = aIn;
		if (A == 1) CrossSum += 1;
		B = bIn;
		if (B == 1) CrossSum += 1;
		C = cIn;
		if (C == 1) CrossSum += 1;
		D = dIn;
		if (D == 1) CrossSum += 1;
		E = eIn;
		if (E == 1) CrossSum += 1;
	}
	
	public ValueQuintett(int[] In) {
		A = In[0];
		if (A == 1) CrossSum += 1;
		B = In[1];
		if (B == 1) CrossSum += 1;
		C = In[2];
		if (C == 1) CrossSum += 1;
		D = In[3];
		if (D == 1) CrossSum += 1;
		E = In[4];
		if (E == 1) CrossSum += 1;
	}
	
	public static int Cs(ValueQuintett v) {
		int cs = 0;
		if (v.A != 0) cs += 1;
		if (v.B != 0) cs += 1;
		if (v.C != 0) cs += 1;
		if (v.D != 0) cs += 1;
		if (v.E != 0) cs += 1;
		return cs;
	}
}

class ValueSextett {
	public int A;
	public int B;
	public int C;
	public int D;
	public int E;
	public int F;
	public int CrossSum;
	
	public ValueSextett() { }
	
	public ValueSextett(int aIn, int bIn, int cIn, int dIn, int eIn, int fIn) {
		A = aIn;
		if (A == 1) CrossSum += 1;
		B = bIn;
		if (B == 1) CrossSum += 1;
		C = cIn;
		if (C == 1) CrossSum += 1;
		D = dIn;
		if (D == 1) CrossSum += 1;
		E = eIn;
		if (E == 1) CrossSum += 1;
		F = fIn;
		if (F == 1) CrossSum += 1;
	}
	
	public ValueSextett(int[] In) {
		A = In[0];
		if (A == 1) CrossSum += 1;
		B = In[1];
		if (B == 1) CrossSum += 1;
		C = In[2];
		if (C == 1) CrossSum += 1;
		D = In[3];
		if (D == 1) CrossSum += 1;
		E = In[4];
		if (E == 1) CrossSum += 1;
		F = In[5];
		if (F == 1) CrossSum += 1;
	}
	
	public static int Cs(ValueSextett v) {
		int cs = 0;
		if (v.A != 0) cs += 1;
		if (v.B != 0) cs += 1;
		if (v.C != 0) cs += 1;
		if (v.D != 0) cs += 1;
		if (v.E != 0) cs += 1;
		if (v.F != 0) cs += 1;
		return cs;
	}
}