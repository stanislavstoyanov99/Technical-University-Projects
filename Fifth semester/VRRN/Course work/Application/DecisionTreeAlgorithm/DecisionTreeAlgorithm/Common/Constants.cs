namespace DecisionTreeAlgorithm.Common
{
    public static class Constants
    {
        // Директория на екселския файл
        public const string ExcelFilePath = "course-work.xlsx";

        // Съобщения при принтиране на даден резултат:

        public const string PThetaConditionalMatrixMessage = "Матрица с условните вероятности P(E|Theta):";

        public const string FullProbabilitiesValuesMessage = "Пълната вероятност P(E) за всеки E:";

        public const string FullConditionalProbabilitiesValuesMessage = "Матрица с апостериорната условна вероятност P(Theta|E):";

        public const string QuantativeValuesMessage = "Количествените оценки Bs от 5-то ниво на дървото:";

        public const string MaximumOfQuantativeEstimatesMessage = "Максималните количествени оценки, получени от 3-то ниво на дървото:";

        public const string ProfitsMessage = "Печалбите Uk:";

        public const string MaxProfitMessage = "Максимална печалба:";

        public const string MessageForExperiment = "Трябва да се проведе експеримент, защото печалбата ще бъде по-голяма.";

        public const string MessageWithoutExperiment = "Не трябва да се провежда експеримент, защото ще бъдем на загуба.";
    }
}
