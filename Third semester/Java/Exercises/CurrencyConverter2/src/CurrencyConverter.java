public class CurrencyConverter {
    double[] exchangeRates;

    void setExchangeRates(double[] rates) {
        exchangeRates = rates;
    }

    void updateExchangeRates(int arrayIndex, double newVal) {
        exchangeRates[arrayIndex] = newVal;
    }

    double getExchangeRates(int arrayIndex) {
        return exchangeRates[arrayIndex];
    }

    double computeTransferRate(int arrayIndex, double amount) {
        return amount * getExchangeRates(arrayIndex);
    }

    void printCurrencies() {
        //TODO
    }
}
