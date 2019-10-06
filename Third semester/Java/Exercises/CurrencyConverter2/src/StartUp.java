public class StartUp {
    public static void main(String[] args) {
        CurrencyConverter cc = new CurrencyConverter();
        double[] rates = {63.0, 3.0, 3.0, 595.0, 18.0, 107.0, 2.0};
        cc.setExchangeRates(rates);
        cc.printCurrencies();
    }
}
