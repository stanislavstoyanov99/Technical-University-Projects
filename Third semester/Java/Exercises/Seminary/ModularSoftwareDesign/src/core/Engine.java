package core;

import contracts.ICommandInterpreter;
import contracts.IEngine;
import contracts.IReader;

public class Engine implements IEngine {

    private IReader reader;
    private ICommandInterpreter commandInterpreter;

    public Engine(IReader reader, ICommandInterpreter commandInterpreter) {
        this.reader = reader;
        this.commandInterpreter = commandInterpreter;
    }

    @Override
    public void run() {
        while (true) {
            System.out.println("Enter command (0=quit, 1=new," +
                    " 2=select, 3=deposit, 4=loan, 5=show, 6=interest): ");

            int cmd = Integer.parseInt(this.reader.readLine());

            this.commandInterpreter.processCommand(cmd);

            if (cmd == 0) {
                break;
            }
        }

        System.out.println("The program has finished! Thank you for using this application.");
    }
}
