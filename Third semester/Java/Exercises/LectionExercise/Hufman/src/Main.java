import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.SortedMap;
import java.util.stream.Collectors;

public class Main {
    static String message = "Zdraveite vsichki";
    static char[] chars = message
            .replaceAll(" ", "")
            .toLowerCase()
            .toCharArray();

    public static void main(String[] args){
        List<Integer> counts = new ArrayList();
        List<Character> charsOnce = new ArrayList();

        for(int i = 0; i < chars.length - 1; i++){
            Integer counter = 1;

            if(chars[i] != ' '){
                for(int y = i; y < chars.length; y++){
                    if(chars[i] == chars[y]){
                        counter++;
                        chars[y] = ' ';
                    }
                }

                counts.add(counter);
                charsOnce.add(chars[i]);
            }
        }

        for(Integer i : counts){
            System.out.println(i);
        }

        for(Character c : charsOnce){
            System.out.println(c);
        }
        List<Integer> sortedCounts =  counts
                .stream()
                .sorted()
                .collect(Collectors.toList());

        Character[] sortedChars = new Character[charsOnce.size()];

        for(int i = 0; i < counts.size(); i++){
            Integer index = sortedCounts
                    .indexOf((counts.get(i)));

            sortedChars[index] = charsOnce.get(i);
        }

        for(int i = 0; i < sortedChars.length; i++){
            System.out.println(sortedChars[i]);
        }

        for(int i = 0; i < sortedCounts.size(); i++){
            System.out.println(sortedCounts.get(i));
        }
    }
}
