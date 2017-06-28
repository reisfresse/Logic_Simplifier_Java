package de.lefrisson.reisfresse.logicsimplifier.Other;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Admin on 26.06.2017.
 * Edited by Admin on 26.06.2017.
 */
public class Simplify {
	private List<ValueDuo> _in2 = new ArrayList<>();
	private List<ValueTrio> _in3 = new ArrayList<>();
	private List<ValueQuartett> _in4 = new ArrayList<>();
	private List<ValueQuintett> _in5 = new ArrayList<>();
	private List<ValueSextett> _in6 = new ArrayList<>();
	private List<ValueDuo> _r2 = new ArrayList<>();
	private List<ValueTrio> _r3 = new ArrayList<>();
	private List<ValueQuartett> _r4 = new ArrayList<>();
	private List<ValueQuintett> _r5 = new ArrayList<>();
	private List<ValueSextett> _r6 = new ArrayList<>();
	
	private List<Integer> _t0 = new ArrayList<>(), _t1 = new ArrayList<>(), _t2 = new ArrayList<>(), _t3 = new ArrayList<>(),
			_t4 = new ArrayList<>(), _t5 = new ArrayList<>(), _t6 = new ArrayList<>();
	
	private int _mode;
	
	private List<Integer> _used = new ArrayList<>();
	
	public void add2(List<ValueDuo> va) {
		_in2 = va;
	}
	
	public void add3(List<ValueTrio> va) {
		_in3 = va;
	}
	
	public void add4(List<ValueQuartett> va) {
		_in4 = va;
	}
	
	public void add5(List<ValueQuintett> va) {
		_in5 = va;
	}
	
	public void add6(List<ValueSextett> va) {
		_in6 = va;
	}
	
	public void setMode(int newMode) {
		// Set new mode
		_mode = newMode;
	}
	
	public boolean prepare() {
		// Bekomme 'mode' und bereite dementsprechend
		// die 'trues' vor
		boolean prepared = true;
		switch (_mode) {
			// In jedem Fall wird von true1 bis true-n geschaut und gespeichert
			case 2:
				true_n(0);
				true_n(1);
				true_n(2);
				break;
			
			case 3:
				true_n(0);
				true_n(1);
				true_n(2);
				true_n(3);
				break;
			
			case 4:
				true_n(0);
				true_n(1);
				true_n(2);
				true_n(3);
				true_n(4);
				break;
			
			case 5:
				true_n(0);
				true_n(1);
				true_n(2);
				true_n(3);
				true_n(4);
				true_n(5);
				break;
			
			case 6:
				true_n(0);
				true_n(1);
				true_n(2);
				true_n(3);
				true_n(4);
				true_n(5);
				true_n(6);
				break;
			
			default:
				prepared = false;
				break;
		}
		return prepared;
	}
	
	public void simple(boolean prepared) {
		if (!prepared) return;
		switch (_mode) {
			case 2:
				_r2 = new ArrayList<>();
				Mode2();
				
				_in2 = new ArrayList<>();
				_in2 = Output.CheckDoubleInDuo(_r2);
				
				Output.Duo(Output.CheckDoubleInDuo(_in2));
				break;
			
			case 3:
				for (int i = 0; i < 2; i++) {
					_r3 = new ArrayList<>();
					Mode3();
					
					_in3 = new ArrayList<>();
					_in3 = Output.CheckDoubleInTrio(_r3);
					
					_t0.clear();
					_t1.clear();
					_t2.clear();
					_t3.clear();
					_used.clear();
					
					for (int j = 0; j < _in3.size(); j++) {
						int cs = ValueTrio.Cs(_in3.get(j));
						if (cs == 0) _t0.add(j);
						if (cs == 1) _t1.add(j);
						if (cs == 2) _t2.add(j);
						if (cs == 3) _t3.add(j);
					}
				}
				
				Output.Trio(Output.CheckDoubleInTrio(_in3));
				break;
			
			case 4:
				for (int i = 0; i < 3; i++) {
					_r4 = new ArrayList<>();
					Mode4();
					
					_in4 = new ArrayList<>();
					_in4 = Output.CheckDoubleInQuartett(_r4);
					
					_t0.clear();
					_t1.clear();
					_t2.clear();
					_t3.clear();
					_t4.clear();
					_used.clear();
					
					for (int j = 0; j < _in4.size(); j++) {
						int cs = ValueQuartett.Cs(_in4.get(j));
						if (cs == 0) _t0.add(j);
						if (cs == 1) _t1.add(j);
						if (cs == 2) _t2.add(j);
						if (cs == 3) _t3.add(j);
						if (cs == 4) _t4.add(j);
					}
				}
				
				Output.Quartett(Output.CheckDoubleInQuartett(_in4));
				break;
			
			case 5:
				for (int i = 0; i < 4; i++) {
					Mode3();
					_in5 = _r5;
				}
				break;
			
			case 6:
				for (int i = 0; i < 5; i++) {
					Mode3();
					_in6 = _r6;
				}
				break;
		}
	}
	
	@SuppressWarnings("Duplicates")
	private void Mode2() {
		// Für jeden in true_0
		for (int true0 : _t0) {
			// und jeden in true_1
			for (int true1 : _t1) {
				ValueDuo a = _in2.get(true0);
				ValueDuo b = _in2.get(true1);
				
				if ((a.A == b.A) && (a.B != b.B)) {
					_r2.add(new ValueDuo(a.A, -1));
					_used.add(true0);
					_used.add(true1);
				}
				if ((a.A != b.A) && (a.B == b.B)) {
					_r2.add(new ValueDuo(-1, a.B));
					_used.add(true0);
					_used.add(true1);
				}
			}
		}
		// Für jeden in true_1
		for (int true1 : _t1) {
			// und jeden in true_2
			for (int true2 : _t2) {
				ValueDuo a = _in2.get(true1);
				ValueDuo b = _in2.get(true2);
				
				if ((a.A == b.A) && (a.B != b.B)) {
					_r2.add(new ValueDuo(a.A, -1));
					_used.add(true1);
					_used.add(true2);
				}
				if ((a.A != b.A) && (a.B == b.B)) {
					_r2.add(new ValueDuo(-1, a.B));
					_used.add(true1);
					_used.add(true2);
				}
			}
		}
		
		// kontrolliere, ob alle aus t0 genutzt wurden
		for (int true0 : _t0) {
			if (_used.contains(true0)) continue;
			_r2.add(new ValueDuo(_in2.get(true0).A, _in2.get(true0).B));
			_used.add(true0);
		}
		
		// kontrolliere, ob alle aus t1 genutzt wurden
		for (int true1 : _t1) {
			if (_used.contains(true1)) continue;
			_r2.add(new ValueDuo(_in2.get(true1).A, _in2.get(true1).B));
			_used.add(true1);
		}
		
		// kontrolliere, ob alle aus t2 genutzt wurden
		for (int true2 : _t2) {
			if (_used.contains(true2)) continue;
			_r2.add(new ValueDuo(_in2.get(true2).A, _in2.get(true2).B));
			_used.add(true2);
		}
	}
	
	@SuppressWarnings("Duplicates")
	private void Mode3() {
		// Für jeden in true_0
		for (int true0 : _t0) {
			// und jeden in true_1
			for (int true1 : _t1) {
				ValueTrio a = _in3.get(true0);
				ValueTrio b = _in3.get(true1);
				
				if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C)) {
					_r3.add(new ValueTrio(a.A, a.B, -1));
					_used.add(true0);
					_used.add(true1);
				} else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C)) {
					_r3.add(new ValueTrio(-1, a.B, a.C));
					_used.add(true0);
					_used.add(true1);
				} else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C)) {
					_r3.add(new ValueTrio(a.A, -1, a.C));
					_used.add(true0);
					_used.add(true1);
				}
			}
		}
		// Für jeden in true_1
		for (int true1 : _t1) {
			// und jeden in true_2
			for (int true2 : _t2) {
				ValueTrio a = _in3.get(true1);
				ValueTrio b = _in3.get(true2);
				
				if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C)) {
					_r3.add(new ValueTrio(a.A, a.B, -1));
					_used.add(true1);
					_used.add(true2);
				} else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C)) {
					_r3.add(new ValueTrio(-1, a.B, a.C));
					_used.add(true1);
					_used.add(true2);
				} else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C)) {
					_r3.add(new ValueTrio(a.A, -1, a.C));
					_used.add(true1);
					_used.add(true2);
				}
			}
		}
		// Für jeden in true_2
		for (int true2 : _t2) {
			// und jeden in true_3
			for (int true3 : _t3) {
				ValueTrio a = _in3.get(true2);
				ValueTrio b = _in3.get(true3);
				
				if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C)) {
					_r3.add(new ValueTrio(a.A, a.B, -1));
					_used.add(true2);
					_used.add(true3);
				} else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C)) {
					_r3.add(new ValueTrio(-1, a.B, a.C));
					_used.add(true2);
					_used.add(true3);
				} else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C)) {
					_r3.add(new ValueTrio(a.A, -1, a.C));
					_used.add(true2);
					_used.add(true3);
				}
			}
		}
		
		// kontrolliere, ob alle aus t0 genutzt wurden
		for (int true0 : _t0) {
			if (_used.contains(true0)) continue;
			_r3.add(new ValueTrio(_in3.get(true0).A, _in3.get(true0).B, _in3.get(true0).C));
			_used.add(true0);
		}
		
		// kontrolliere, ob alle aus t1 genutzt wurden
		for (int true1 : _t1) {
			if (_used.contains(true1)) continue;
			_r3.add(new ValueTrio(_in3.get(true1).A, _in3.get(true1).B, _in3.get(true1).C));
			_used.add(true1);
		}
		
		// kontrolliere, ob alle aus t2 genutzt wurden
		for (int true2 : _t2) {
			if (_used.contains(true2)) continue;
			_r3.add(new ValueTrio(_in3.get(true2).A, _in3.get(true2).B, _in3.get(true2).C));
			_used.add(true2);
		}
		
		// kontrolliere, ob alle aus t3 genutzt wurden
		for (int true3 : _t3) {
			if (_used.contains(true3)) continue;
			_r3.add(new ValueTrio(_in3.get(true3).A, _in3.get(true3).B, _in3.get(true3).C));
			_used.add(true3);
		}
	}
	
	@SuppressWarnings("Duplicates")
	private void Mode4() {
		// Für jeden in true_0
		for (int true0 : _t0) {
			// und jeden in true_1
			for (int true1 : _t1) {
				ValueQuartett a = _in4.get(true0);
				ValueQuartett b = _in4.get(true1);
				
				if ((a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D != b.D)) { // abc-
					_r4.add(new ValueQuartett(a.A, a.B, a.C, -1));
					_used.add(true0);
					_used.add(true1);
				} else if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C) && (a.D == b.D)) { // ab-d
					_r4.add(new ValueQuartett(a.A, a.B, -1, a.D));
					_used.add(true0);
					_used.add(true1);
				} else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C) && (a.D == b.D)) { // a-cd
					_r4.add(new ValueQuartett(a.A, -1, a.C, a.D));
					_used.add(true0);
					_used.add(true1);
				} else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D)) { // -bcd
					_r4.add(new ValueQuartett(-1, a.B, a.C, a.D));
					_used.add(true0);
					_used.add(true1);
				}
			}
		}
		// Für jeden in true_1
		for (int true1 : _t1) {
			// und jeden in true_2
			for (int true2 : _t2) {
				ValueQuartett a = _in4.get(true1);
				ValueQuartett b = _in4.get(true2);
				
				if ((a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D != b.D)) { // abc-
					_r4.add(new ValueQuartett(a.A, a.B, a.C, -1));
					_used.add(true1);
					_used.add(true2);
				} else if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C) && (a.D == b.D)) { // ab-d
					_r4.add(new ValueQuartett(a.A, a.B, -1, a.D));
					_used.add(true1);
					_used.add(true2);
				} else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C) && (a.D == b.D)) { // a-cd
					_r4.add(new ValueQuartett(a.A, -1, a.C, a.D));
					_used.add(true1);
					_used.add(true2);
				} else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D)) { // -bcd
					_r4.add(new ValueQuartett(-1, a.B, a.C, a.D));
					_used.add(true1);
					_used.add(true2);
				}
			}
		}
		// Für jeden in true_2
		for (int true2 : _t2) {
			// und jeden in true_3
			for (int true3 : _t3) {
				ValueQuartett a = _in4.get(true2);
				ValueQuartett b = _in4.get(true3);
				
				if ((a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D != b.D)) { // abc-
					_r4.add(new ValueQuartett(a.A, a.B, a.C, -1));
					_used.add(true2);
					_used.add(true3);
				} else if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C) && (a.D == b.D)) { // ab-d
					_r4.add(new ValueQuartett(a.A, a.B, -1, a.D));
					_used.add(true2);
					_used.add(true3);
				} else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C) && (a.D == b.D)) { // a-cd
					_r4.add(new ValueQuartett(a.A, -1, a.C, a.D));
					_used.add(true2);
					_used.add(true3);
				} else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D)) { // -bcd
					_r4.add(new ValueQuartett(-1, a.B, a.C, a.D));
					_used.add(true2);
					_used.add(true3);
				}
			}
		}
		
		// Für jeden in true_3
		for (int true3 : _t3) {
			// und jeden in true_4
			for (int true4 : _t4) {
				ValueQuartett a = _in4.get(true3);
				ValueQuartett b = _in4.get(true4);
				
				if ((a.A == b.A) && (a.B == b.B) && (a.C == b.C) && (a.D != b.D)) { // abc-
					_r4.add(new ValueQuartett(a.A, a.B, a.C, -1));
					_used.add(true3);
					_used.add(true4);
				} else if ((a.A == b.A) && (a.B == b.B) && (a.C != b.C) && (a.D == b.D)) { // ab-d
					_r4.add(new ValueQuartett(a.A, a.B, -1, a.D));
					_used.add(true3);
					_used.add(true4);
				} else if ((a.A == b.A) && (a.B != b.B) && (a.C == b.C) && (a.D == b.D)) { // a-cd
					_r4.add(new ValueQuartett(a.A, -1, a.C, a.D));
					_used.add(true3);
					_used.add(true4);
				} else if ((a.A != b.A) && (a.B == b.B) && (a.C == b.C) && (a.D == b.D)) { // -bcd
					_r4.add(new ValueQuartett(-1, a.B, a.C, a.D));
					_used.add(true3);
					_used.add(true4);
				}
			}
		}
		
		// kontrolliere, ob alle aus t0 genutzt wurden
		for (int true0 : _t0) {
			if (_used.contains(true0)) continue;
			_r4.add(new ValueQuartett(_in4.get(true0).A, _in4.get(true0).B, _in4.get(true0).C, _in4.get(true0).D));
			_used.add(true0);
		}
		
		// kontrolliere, ob alle aus t1 genutzt wurden
		for (int true1 : _t1) {
			if (_used.contains(true1)) continue;
			_r4.add(new ValueQuartett(_in4.get(true1).A, _in4.get(true1).B, _in4.get(true1).C, _in4.get(true1).D));
			_used.add(true1);
		}
		
		// kontrolliere, ob alle aus t2 genutzt wurden
		for (int true2 : _t2) {
			if (_used.contains(true2)) continue;
			_r4.add(new ValueQuartett(_in4.get(true2).A, _in4.get(true2).B, _in4.get(true2).C, _in4.get(true2).D));
			_used.add(true2);
		}
		
		// kontrolliere, ob alle aus t3 genutzt wurden
		for (int true3 : _t3) {
			if (_used.contains(true3)) continue;
			_r4.add(new ValueQuartett(_in4.get(true3).A, _in4.get(true3).B, _in4.get(true3).C, _in4.get(true3).D));
			_used.add(true3);
		}
		
		// kontrolliere, ob alle aus t4 genutzt wurden
		for (int true4 : _t4) {
			if (_used.contains(true4)) continue;
			_r4.add(new ValueQuartett(_in4.get(true4).A, _in4.get(true4).B, _in4.get(true4).C, _in4.get(true4).D));
			_used.add(true4);
		}
	}
	
	private void true_n(int round) {
		switch (_mode) {
			case 2:
				// ValueDuo, t1 and t2 should be filled up
				for (int i = 0; i < _in2.size(); i++) {
					// check for every ValueDuo the cross_sum
					if (_in2.get(i).CrossSum != round) continue;
					switch (round) {
						case 0:
							_t0.add(i);
							break;
						
						case 1:
							_t1.add(i);
							break;
						
						case 2:
							_t2.add(i);
							break;
					}
				}
				break;
			
			case 3:
				// ValueTrio, t1, t2 and t3 should be filled up
				for (int i = 0; i < _in3.size(); i++) {
					// check for every ValueTrio the cross_sum
					if (_in3.get(i).CrossSum != round) continue;
					switch (round) {
						case 0:
							_t0.add(i);
							break;
						
						case 1:
							_t1.add(i);
							break;
						
						case 2:
							_t2.add(i);
							break;
						
						case 3:
							_t3.add(i);
							break;
					}
				}
				break;
			
			case 4:
				// ValueQuartett, t1, t2, t3 and t4 should be filled up
				for (int i = 0; i < _in4.size(); i++) {
					// check for every ValueTrio the cross_sum
					if (_in4.get(i).CrossSum != round) continue;
					switch (round) {
						case 0:
							_t0.add(i);
							break;
						
						case 1:
							_t1.add(i);
							break;
						
						case 2:
							_t2.add(i);
							break;
						
						case 3:
							_t3.add(i);
							break;
						
						case 4:
							_t4.add(i);
							break;
					}
				}
				break;
			
			case 5:
				// ValueQuintett, t1, t2, t3, t4 and t5 should be filled up
				for (int i = 0; i < _in5.size(); i++) {
					// check for every ValueTrio the cross_sum
					if (_in5.get(i).CrossSum != round) continue;
					switch (round) {
						case 0:
							_t0.add(i);
							break;
						
						case 1:
							_t1.add(i);
							break;
						
						case 2:
							_t2.add(i);
							break;
						
						case 3:
							_t3.add(i);
							break;
						
						case 4:
							_t4.add(i);
							break;
						
						case 5:
							_t5.add(i);
							break;
					}
				}
				break;
			
			case 6:
				// ValueSextett, t1, t2, t3, t4, t5 and t6 should be filled up
				for (int i = 0; i < _in6.size(); i++) {
					// check for every ValueTrio the cross_sum
					if (_in6.get(i).CrossSum != round) continue;
					switch (round) {
						case 0:
							_t0.add(i);
							break;
						
						case 1:
							_t1.add(i);
							break;
						
						case 2:
							_t2.add(i);
							break;
						
						case 3:
							_t3.add(i);
							break;
						
						case 4:
							_t4.add(i);
							break;
						
						case 5:
							_t5.add(i);
							break;
						
						case 6:
							_t6.add(i);
							break;
					}
				}
				break;
		}
	}
	
	public List<ValueDuo> getDuo() {
		return _in2;
	}
	
	public List<ValueTrio> getTrio() {
		return _in3;
	}
	
	public List<ValueQuartett> getQuartett() {
		return _in4;
	}
}
