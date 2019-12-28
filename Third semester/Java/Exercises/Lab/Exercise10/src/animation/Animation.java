package animation;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Animation extends JApplet implements Runnable, ActionListener {
    int miFrameNumber = -1;
    int miTimeStep;
    Thread mAnimationThread;
    boolean mblsPaused = false;
    Button mButton;
    Point mCenter;
    int miRadius;
    int miDX, miDY;

    public void init() {
        // Make the animation run at 20 frames per second. We do this by
        // setting the timestep to 50ms.
        miTimeStep = 50;

        // Initializa the parameters of the circle.
        mCenter = new Point(getSize().width / 2, getSize().height / 2);
        miRadius = 15;
        miDX = 4; // X offset per timestep.
        miDY = 3; // Y offset per timestep.

        // Create a button to start and stop the animation.
        mButton = new Button("Stop");
        getContentPane().add(mButton, "North");
        mButton.addActionListener(this);

        // Create a JPanel subclass and add it to the JApplet. All drawing
        // will be done here, do we must write the paintComponent() method.
        // Note that the anonymous class has access to the private data of
        // class Animation, because it is defined locally.
        getContentPane().add(new JPanel() {
            public void paintComponent(Graphics g) {
                // Paint the background.
                super.paintComponent(g);

                // Display the frame number.
                g.drawString("Frame " + miFrameNumber, getSize().width / 2 - 40, getSize().height - 15);

                // Draw the circle.
                g.setColor(Color.red);
                g.fillOval(mCenter.x - miRadius, mCenter.y - miRadius, 2 * miRadius, 2 * miRadius);
            }
        }, "Center");
    }

    public void start() {
        if (mblsPaused) {
            // Dont'do anything. The animation has been paused.
        }
        else {
            // Start animating.
            if (mAnimationThread == null) {
                mAnimationThread = new Thread(this);
            }

            mAnimationThread.start();
        }
    }

    public void stop() {
        // Stop the animating thread by setting the mAnimationThread variable
        // to null. This will cause the thread to break out of the while loop,
        // so that the run() method terminates naturally.
        mAnimationThread = null;
    }

    @Override
    public void actionPerformed(ActionEvent actionEvent) {
        if (mblsPaused) {
            mblsPaused = false;
            mButton.setLabel("Stop");
            start();
        }
        else {
            mblsPaused = true;
            mButton.setLabel("Start");
            stop();
        }
    }

    @Override
    public void run() {
        // Just to be nice, lower this thread's priority so it can't
        // interfere with other processing going on.
        Thread.currentThread().setPriority(Thread.MIN_PRIORITY);

        // Remember the starting time
        long startTime = System.currentTimeMillis();

        // Remember which thread we are.
        Thread currentThread = Thread.currentThread();

        // This is the animation loop
        while (currentThread == mAnimationThread) {
            // Advance the animation frame.
            miFrameNumber++;

            // Update hte position of the circle.
            move();

            // Draw the next frame.
            repaint();

            // Delay depending on how far we are behind.
            try {
                startTime += miTimeStep;
                Thread.sleep(Math.max(0, startTime - System.currentTimeMillis()));
            }
            catch (InterruptedException e) {
                break;
            }
        }
    }

    // Update the position of the circle.
    void move() {
        mCenter.x += miDX;

        if (mCenter.x - miRadius < 0 || mCenter.x + miRadius > getSize().width) {
            miDX = -miDX;
            mCenter.x += 2 * miDX;
        }

        mCenter.y += miDY;
        if (mCenter.y - miRadius < 0 || mCenter.y + miRadius > getSize().height) {
            miDY = -miDY;
            mCenter.y += 2 * miDY;
        }
    }
}
