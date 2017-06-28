package de.lefrisson.reisfresse.logicsimplifier.MainForm;

import de.lefrisson.reisfresse.logicsimplifier.Inputs.DNF;
import de.lefrisson.reisfresse.logicsimplifier.Inputs.KV;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

/**
 * Created by Admin on 25.06.2017.
 * Edited by Admin on 25.06.2017.
 */
public class MainForm extends JFrame {
	public MainForm() {
		new MainFormDesigner(this);
	}
	
	public void paint(Graphics g) {
		super.paintComponents(g);
	}
}

class MainFormDesigner {
	private JButton KVtoQMC;
	private JButton DNFtoQMC;
	private JButton about;
	private JButton exit;
	private MainFormListener listener;
	private MainForm frame;
	
	MainFormDesigner(MainForm frame) {
		this.frame = frame;
		
		this.KVtoQMC = new JButton();
		this.DNFtoQMC = new JButton();
		this.about = new JButton();
		this.exit = new JButton();
		this.listener = new MainFormListener(frame);
		//
		// KVtoQMC
		//
		KVtoQMC.setBackground(Color.LIGHT_GRAY);
		KVtoQMC.setCursor(new Cursor(Cursor.HAND_CURSOR));
		KVtoQMC.setText("KV -> QMC");
		KVtoQMC.addActionListener(listener);
		KVtoQMC.setActionCommand("kv");
		KVtoQMC.setBounds(122, 12, 100, 35);
		//
		// DNFtoQMC
		//
		DNFtoQMC.setBackground(Color.LIGHT_GRAY);
		DNFtoQMC.setCursor(new Cursor(Cursor.HAND_CURSOR));
		DNFtoQMC.setText("DNF -> QMC");
		DNFtoQMC.addActionListener(listener);
		DNFtoQMC.setActionCommand("dnf");
		DNFtoQMC.setBounds(12, 12, 100, 35);
		//
		// about
		//
		about.setBackground(Color.LIGHT_GRAY);
		about.setCursor(new Cursor(Cursor.HAND_CURSOR));
		about.setText("About");
		about.addActionListener(listener);
		about.setActionCommand("about");
		about.setBounds(12, 54, 100, 35);
		//
		// exit
		//
		exit.setBackground(Color.LIGHT_GRAY);
		exit.setCursor(new Cursor(Cursor.HAND_CURSOR));
		exit.setText("Exit");
		exit.addActionListener(listener);
		exit.setActionCommand("exit");
		exit.setBounds(122, 54, 100, 35);
		//
		// MainForm
		//
		frame.setBounds(200, 100, 240, 130);
		frame.addWindowListener(new MainFormWindowListener());
		frame.setLayout(null);
		frame.add(this.exit);
		frame.add(this.about);
		frame.add(this.DNFtoQMC);
		frame.add(this.KVtoQMC);
		frame.setBackground(Color.GRAY);
		frame.setResizable(false);
		frame.setName("Logic Simplifier");
		frame.setVisible(true);
	}
	
}

class MainFormWindowListener implements WindowListener {
	@Override
	public void windowOpened(WindowEvent e) {}
	
	@Override
	public void windowClosing(WindowEvent e) {
		e.getWindow().dispose();
		System.exit(0);
	}
	
	@Override
	public void windowClosed(WindowEvent e) {}
	
	@Override
	public void windowIconified(WindowEvent e) {}
	
	@Override
	public void windowDeiconified(WindowEvent e) {}
	
	@Override
	public void windowActivated(WindowEvent e) {}
	
	@Override
	public void windowDeactivated(WindowEvent e) {}
}

class MainFormListener implements ActionListener {
	private MainForm frame;
	private DNF dnf;
	private KV kv;
	private About about;
	
	MainFormListener(MainForm frame) {
		this.frame = frame;
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
		String cmd = e.getActionCommand();
		
		switch (cmd) {
			case "exit":
				frame.dispose();
				System.exit(0);
			case "dnf":
				if (dnf.isVisible()) {
					dnf.setVisible(false);
					dnf.dispose();
				} else {
					dnf = new DNF();
					dnf.setVisible(true);
				}
				break;
			case "kv":
				if (kv.isVisible()) {
					kv.setVisible(false);
					kv.dispose();
				} else {
					kv = new KV();
					kv.setVisible(true);
				}
				break;
			case "about":
				if (about == null) {
					about = new About();
					about.setVisible(true);
				} else if (about.isVisible()) {
					about.setVisible(false);
					about.dispose();
				} else {
					about = new About();
					about.setVisible(true);
				}
				break;
		}
	}
}
