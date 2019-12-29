import models.Dolphin;
import models.Whale;
import models.Oceanographer;

public class StartUp {
    public static void main(String[] args) {
        Oceanographer oceanographer = new Oceanographer();
        oceanographer.checkSound(new Dolphin());
        oceanographer.checkSound(new Whale());
    }
}
