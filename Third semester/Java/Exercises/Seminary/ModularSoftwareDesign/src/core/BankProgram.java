package core;

import contracts.ICommandInterpreter;
import contracts.IEngine;
import contracts.IManagerController;
import contracts.IReader;

import java.util.HashMap;

public class BankProgram {
    public static void main(String[] args) {
        IReader reader = new Reader();
        HashMap<Integer, Integer> accounts = new HashMap<Integer, Integer>();

        IManagerController managerController = new ManagerController(reader, accounts);
        ICommandInterpreter commandInterpreter = new CommandInterpreter(managerController);
        IEngine engine = new Engine(reader, commandInterpreter);

        engine.run();
    }
}
