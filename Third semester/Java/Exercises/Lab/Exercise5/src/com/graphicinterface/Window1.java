package com.graphicinterface;

import java.awt.event.*;
import javax.swing.*;

public class Window1 {
    public static void main(String [] args) {
        JFrame wd = new JFrame();
        wd.setSize(300, 100);
        wd.setTitle("graphic window");
        wd.setVisible(true);
        wd.addWindowListener(new WndCls());
    }

    // To close the graphic thread:
    public static class WndCls extends WindowAdapter {
        public void windowClosing(WindowEvent event) {
            System.exit(0);
        }
    }
}
