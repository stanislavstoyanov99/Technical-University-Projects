package core;

import contracts.ICommandInterpreter;
import contracts.IManagerController;

public class CommandInterpreter implements ICommandInterpreter {
    private IManagerController managerController;

    public CommandInterpreter(IManagerController managerController) {
        this.managerController = managerController;
    }

    @Override
    public void processCommand(int cmd) {
        switch (cmd) {
            case 0: this.managerController.quit();
                    break;
            case 1: this.managerController.newAccount();
                    break;
            case 2: this.managerController.select();
                    break;
            case 3: this.managerController.deposit();
                    break;
            case 4: this.managerController.authorizeLoan();
                    break;
            case 5: this.managerController.showAll();
                    break;
            case 6: this.managerController.addInterest();
                    break;
            default: System.out.println("Invalid command.");
        }
    }
}
