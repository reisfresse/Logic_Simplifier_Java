package de.lefrisson.reisfresse.logicsimplifier.Other;

import de.lefrisson.reisfresse.logicsimplifier.MainForm.MainForm;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;

/**
 * Created by Admin on 26.06.2017.
 * Edited by Admin on 26.06.2017.
 */
class Output {
	static boolean EqualsDuo(ValueDuo a, ValueDuo b) {
		return a.A == b.A && a.B == b.B;
	}
	
	static List<ValueDuo> CheckDoubleInDuo(List<ValueDuo> value) {
		List<Integer> doub = new ArrayList<>();
		int length = value.size();
		
		for (int i = 0; i < length; i++)
			for (int j = i + 1; j < length; j++)
				if (EqualsDuo(value.get(i), value.get(j)))
					doub.add(j);
		
		List<ValueDuo> res = value;
		Collections.sort(doub);
		doub = new ArrayList(new HashSet(doub));
		Collections.reverse(doub);
		
		for (int i : doub)
			res.remove(i);
		
		return res;
	}
	
	static String[] Duo(List<ValueDuo> value) {
		List<String> list = new ArrayList<>();
		// Gebe DataGrid in Debugfenster aus
		for (ValueDuo t : value) {
			String values = "";
			
			if (t.A == -1)
				values += " " + "-";
			else
				values += " " + t.A;
			
			if (t.B == -1)
				values += " " + "-";
			else
				values += " " + t.B;
			
			list.add(values);
		}
		return list.toArray(new String[list.size()]);
	}
	
	static boolean EqualsTrio(ValueTrio a, ValueTrio b) {
		return a.A == b.A && a.B == b.B && a.C == b.C;
	}
	
	static List<ValueTrio> CheckDoubleInTrio(List<ValueTrio> value) {
		List<Integer> doub = new ArrayList<>();
		int length = value.size();
		
		for (int i = 0; i < length; i++)
			for (int j = i + 1; j < length; j++)
				if (EqualsTrio(value.get(i), value.get(j)))
					doub.add(j);
		
		List<ValueTrio> res = value;
		Collections.sort(doub);
		doub = new ArrayList(new HashSet(doub));
		Collections.reverse(doub);
		
		for (int i : doub)
			res.remove(i);
		
		return res;
	}
	
	static String[] Trio(List<ValueTrio> value) {
		List<String> list = new ArrayList<>();
		
		// Gebe DataGrid in Debugfenster aus
		for (ValueTrio t : value) {
			String values = "";
			
			if (t.A == -1)
				values += " " + "-";
			else
				values += " " + t.A;
			
			if (t.B == -1)
				values += " " + "-";
			else
				values += " " + t.B;
			
			if (t.C == -1)
				values += " " + "-";
			else
				values += " " + t.C;
			
			list.add(values);
		}
		return list.toArray(new String[list.size()]);
	}
	
	static boolean EqualsQuartett(ValueQuartett a, ValueQuartett b) {
		return a.A == b.A && a.B == b.B && a.C == b.C && a.D == b.D;
	}
	
	static List<ValueQuartett> CheckDoubleInQuartett(List<ValueQuartett> value) {
		List<Integer> doub = new ArrayList<>();
		int length = value.size();
		
		for (int i = 0; i < length; i++)
			for (int j = i + 1; j < length; j++)
				if (EqualsQuartett(value.get(i), value.get(j)))
					doub.add(j);
		
		List<ValueQuartett> res = value;
		Collections.sort(doub);
		doub = new ArrayList(new HashSet(doub));
		Collections.reverse(doub);
		
		for (int i : doub)
			res.remove(i);
		
		return res;
	}
	
	static String[] Quartett(List<ValueQuartett> value) {
		List<String> list = new ArrayList<>();
		
		// Gebe DataGrid in Debugfenster aus
		for (ValueQuartett t : value) {
			String values = "";
			
			if (t.A == -1)
				values += " " + "-";
			else
				values += " " + t.A;
			
			if (t.B == -1)
				values += " " + "-";
			else
				values += " " + t.B;
			
			if (t.C == -1)
				values += " " + "-";
			else
				values += " " + t.C;
			
			if (t.D == -1)
				values += " " + "-";
			else
				values += " " + t.D;
			list.add(values);
		}
		return list.toArray(new String[list.size()]);
	}
}
