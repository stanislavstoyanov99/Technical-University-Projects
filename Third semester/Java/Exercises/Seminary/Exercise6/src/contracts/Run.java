package contracts;

public interface Run extends Walk {
    boolean canHuntWhileRunning();
    double getMaxSpeed();
}
