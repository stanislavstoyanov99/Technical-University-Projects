package contracts;

import models.Animal;

// Same as Predicate<T>
public interface CheckTrait {
    boolean test(Animal a);
}
