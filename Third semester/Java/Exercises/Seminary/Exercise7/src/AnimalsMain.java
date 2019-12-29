import models.Lemur;
import models.Primate;
import contracts.HasTail;

public class AnimalsMain {
    public static void main(String[] args) {
        Lemur lemur = new Lemur();
        System.out.println(lemur.age);

        // Polymorphism
        HasTail hasTail = lemur;
        System.out.println(hasTail.isTailStriped());
        // System.out.println(hasTail.age); DOES NOT COMPILE

        Primate primate = lemur;
        System.out.println(primate.hasHair());
        // System.out.println(primate.isTailStriped()); DOES NOT COMPILE

        // Lemur lemur2 = primate; DOES NOT COMPILE

        Lemur lemur3 = (Lemur)primate;
        System.out.println(lemur3.age);
    }
}
