package de.lefrisson.reisfresse.logicsimplifier.MainForm;

import de.lefrisson.reisfresse.logicsimplifier.Program;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

/**
 * Created by Admin on 26.06.2017.
 * Edited by Admin on 26.06.2017.
 */
public class About extends JFrame {
	public final String DATA = " Version " + Program.VERSION + "\n This program is free software\n\n Copyright (c) 2016 by ReisfresseDE\n reisfressede@gmail.com";
	
	public About() {
		new AboutDesigner(this);
	}
}

class AboutDesigner {
	private About frame;
	private AboutListener listener;
	private JTextArea label;
	
	AboutDesigner(About frame) {
		this.frame = frame;
		this.listener = new AboutListener(frame);
		
		label = new JTextArea();
		label.setEditable(false);
		label.setBackground(Color.LIGHT_GRAY);
		label.setText(frame.DATA);
		label.addMouseListener(listener);
		
		frame.setBounds(100, 100, 270, 120);
		frame.add(label);
		frame.setResizable(false);
	}
}

class AboutListener implements MouseListener {
	private About frame;
	
	AboutListener(About frame) {
		this.frame = frame;
	}
	
	@Override
	public void mouseClicked(MouseEvent e) {
	
	}
	
	@Override
	public void mousePressed(MouseEvent e) {
		frame.setVisible(false);
		frame.dispose();
	}
	
	@Override
	public void mouseReleased(MouseEvent e) {
	
	}
	
	@Override
	public void mouseEntered(MouseEvent e) {
	
	}
	
	@Override
	public void mouseExited(MouseEvent e) {
	
	}
}