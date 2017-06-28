package de.lefrisson.reisfresse.logicsimplifier.Other;

import de.lefrisson.reisfresse.logicsimplifier.MainForm.About;
import de.lefrisson.reisfresse.logicsimplifier.MainForm.AboutListener;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by Admin on 28.06.2017.
 * Edited by Admin on 28.06.2017.
 */
public class OutputDNF extends JFrame {
	OutputDNF() {
		OutputDNFDesigner designer = new OutputDNFDesigner(this);
	}
}

class OutputDNFDesigner {
	private OutputDNF frame;
	private OutputDNFListener listener;
	
	public OutputDNFDesigner(OutputDNF frame) {
		this.frame = frame;
		listener = new OutputDNFListener(frame);
	}
}

class OutputDNFListener implements ActionListener {
	OutputDNF frame;
	
	OutputDNFListener(OutputDNF frame) {
		this.frame = frame;
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
	
	}
}
