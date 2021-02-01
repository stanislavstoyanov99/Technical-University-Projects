namespace DecisionTreeAlgorithm
{
    using System;
    using System.IO;
    using System.Linq;

    using DecisionTreeAlgorithm.Common;

    using OfficeOpenXml;

    public class Algorithm
    {
        public static void Main()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Прочитане на входните данни на задачата от MS Excel
            using var package = new ExcelPackage(new FileInfo(Constants.ExcelFilePath));

            var excelData = package.Workbook.Worksheets["ProgramData"];

            // Прочитане на печалбите при провеждане на експеримент за първата алтернатива V1
            var firstAlternativeЕxpProfits = excelData.Cells["F3:F6"]
                .Select(x => double.Parse(x.Value.ToString()))
                .ToList();

            // Прочитане на печалбите при провеждане на експеримент за втората алтернатива V2
            var secondAlternativeExpProfits = excelData.Cells["C19:C22"]
                .Select(x => double.Parse(x.Value.ToString()))
                .ToList();

            // Прочитане на печалбите без извършване на експеримент за първата алтернатива V1
            var firstAlternativeNoExpProfits = excelData.Cells["B36:B39"]
                .Select(x => double.Parse(x.Value.ToString()))
                .ToList();

            // Прочитане на печалбите без извършване на експеримент за втората алтернатива V2
            var secondAlternativeNoExpProfits = excelData.Cells["C36:C39"]
                .Select(x => double.Parse(x.Value.ToString()))
                .ToList();

            // Прочитане на вероятностите за поява на околната среда p(тита)
            var pThetaValues = excelData.Cells["E3:E6"]
                .Select(x => double.Parse(x.Value.ToString()))
                .ToList();

            // Прочитане на стойностите за експеримента при отсъствие на ресурси за трите територии
            var missingResourcesValues = excelData.Cells["E10:G10"]
                .Select(x => double.Parse(x.Value.ToString()))
                .ToList();

            // Прочитане на стойностите за експеримента при наличие само на един ресурс от вид 1 за трите територии
            var existingResourceOneValues = excelData.Cells["E11:G11"]
                .Select(x => double.Parse(x.Value.ToString()))
                .ToList();

            // Прочитане на стойностите за експеримента при наличие на два ресурса от вид 2 за трите територии
            var existingTwoResourcesValues = excelData.Cells["E12:G12"]
                .Select(x => double.Parse(x.Value.ToString()))
                .ToList();

            // Прочитане на стойностите за експеримента при наличие само на един ресурс от вид 2 за трите територии
            var existingResourceTwoValues = excelData.Cells["E13:G13"]
                .Select(x => double.Parse(x.Value.ToString()))
                .ToList();

            // Цена за провеждане на експеримента
            var priceOfExperiment = double.Parse(excelData.Cells["D16"].Text);

            // Брой на изходите от експеримента
            var totalCountOfExperiments = int.Parse(excelData.Cells["E31"].Text);

            // Брой на алтернативите на околната среда
            var thetaCount = pThetaValues.Count;

            // Брой на алтернативите
            var alternativesCount = 2;

            // ** Алгоритъм за решаване на задачата **

            // Общ брой на всеки тип от наличните ресурси
            var missingResourcesCount = double.Parse(excelData.Cells["H10"].Text);
            var existingResourceOneCount = double.Parse(excelData.Cells["H11"].Text);
            var existingTwoResourcesCount = double.Parse(excelData.Cells["H12"].Text);
            var existingResourceTwoCount = double.Parse(excelData.Cells["H13"].Text);

            // Изчисляване на условните вероятности P(ε | θ)
            var pThetaConditionalMatrix = new double[pThetaValues.Count, totalCountOfExperiments];

            for (int row = 0; row < pThetaConditionalMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < pThetaConditionalMatrix.GetLength(1); col++)
                {
                    if (row == 0)
                    {
                        pThetaConditionalMatrix[row, col] = missingResourcesValues[col] / missingResourcesCount;
                    }
                    else if (row == 1)
                    {
                        pThetaConditionalMatrix[row, col] = existingResourceOneValues[col] / existingResourceOneCount;
                    }
                    else if (row == 2)
                    {
                        pThetaConditionalMatrix[row, col] = existingTwoResourcesValues[col] / existingTwoResourcesCount;
                    }
                    else if (row == 3)
                    {
                        pThetaConditionalMatrix[row, col] = existingResourceTwoValues[col] / existingResourceTwoCount;
                    }
                }
            }

            // Принтиране на резултата от получената матрица
            Console.WriteLine(Constants.PThetaConditionalMatrixMessage);
            Utility.PrintMatrix(pThetaConditionalMatrix);

            // Определяне на апостериорните условни вероятности ρ(θ | ε)

            // Изчисляване на пълните вероятности P(Ek)
            var fullProbabilitiesValues = new double[totalCountOfExperiments];
            int currColInCondMatrix = 0;

            for (int i = 0; i < totalCountOfExperiments; i++)
            {
                for (int row = 0; row < pThetaConditionalMatrix.GetLength(0); row++)
                {
                    // За всеки от експериментите се смята пълната вероятност по формулата, описана в текстовото описание на курсовата работа
                    fullProbabilitiesValues[i] += pThetaConditionalMatrix[row, currColInCondMatrix] * pThetaValues[row];
                }

                currColInCondMatrix++;
            }

            // Принтиране стойностите на пълните вероятности P(Ek)
            Console.WriteLine();
            Console.WriteLine(Constants.FullProbabilitiesValuesMessage);
            Utility.PrintArray(fullProbabilitiesValues);

            // Изчисляване на апостериорните условни вероятности ρ(θ | ε)
            var fullConditionalProbabilitiesMatrix = new double[totalCountOfExperiments, pThetaValues.Count];

            for (int row = 0; row < fullConditionalProbabilitiesMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < fullConditionalProbabilitiesMatrix.GetLength(1); col++)
                {
                    // За всеки от експериментите се смята апостериорната условна вероятност по формулата, описана в текстовото описание на курсовата работа
                    fullConditionalProbabilitiesMatrix[row, col] =
                        pThetaValues[col] * pThetaConditionalMatrix[col, row] / fullProbabilitiesValues[row];
                }
            }

            // Принтиране стойностите на апостериорните условни вероятности ρ(θ | ε)
            Console.WriteLine();
            Console.WriteLine(Constants.FullConditionalProbabilitiesValuesMessage);
            Utility.PrintMatrix(fullConditionalProbabilitiesMatrix);

            // Изчисляване на количествените оценки ξ(Bs) за всяка печалба Bs от 5то ниво на дървото
            var quantativeEstimates = new double[thetaCount * alternativesCount];
            var totalExpProfits = (thetaCount * alternativesCount) - alternativesCount;
            var totalNoExpProfits = quantativeEstimates.Length - totalExpProfits;
            int currMatrixRow = 0;

            // Изчисляване на количествените оценки за клоновете при проведен експеримент
            for (int i = 0; i < totalExpProfits; i++)
            {
                for (int j = 0; j < firstAlternativeЕxpProfits.Count; j++)
                {
                    if (i % 2 == 0)
                    {
                        quantativeEstimates[i] +=
                            firstAlternativeЕxpProfits[j] * fullConditionalProbabilitiesMatrix[currMatrixRow, j];
                    }
                    else
                    {
                        quantativeEstimates[i] +=
                            secondAlternativeExpProfits[j] * fullConditionalProbabilitiesMatrix[currMatrixRow, j];
                    }
                }

                if (i % 2 != 0)
                {
                    currMatrixRow++;
                }
            }

            // Изчисляване на количествените оценки за клоновете без провеждане на експеримент
            for (int i = quantativeEstimates.Length - totalNoExpProfits; i < quantativeEstimates.Length; i++)
            {
                for (int j = 0; j < secondAlternativeNoExpProfits.Count; j++)
                {
                    if (i % 2 == 0)
                    {
                        quantativeEstimates[i] +=
                            firstAlternativeNoExpProfits[j] * pThetaValues[j];
                    }
                    else
                    {
                        quantativeEstimates[i] +=
                            secondAlternativeNoExpProfits[j] * pThetaValues[j];
                    }
                }
            }

            // Принтиране на всички количествени оценки от 5-то ниво на дървото
            Console.WriteLine();
            Console.WriteLine(Constants.QuantativeValuesMessage);
            Utility.PrintArray(quantativeEstimates);

            // Изчисляване на максимумите на всеки две количествени оценки (Стъпка 4 от текстовото представяне на алгоритъма)
            var maximumOfQuantativeEstimates = new double[quantativeEstimates.Length / 2];
            var currIndex = 0;

            for (int i = 0; i < quantativeEstimates.Length; i += 2)
            {
                maximumOfQuantativeEstimates[currIndex] = Math.Max(quantativeEstimates[i], quantativeEstimates[i + 1]);
                currIndex++;
            }

            // Принтиране на максимумите на количествените оценки от 3-то ниво на дървото
            Console.WriteLine();
            Console.WriteLine(Constants.MaximumOfQuantativeEstimatesMessage);
            Utility.PrintArray(maximumOfQuantativeEstimates);

            // Изчисляване на печалбите μk (Стъпка 5 и 6 от текстовото представяне на алгоритъма)
            var profits = new double[maximumOfQuantativeEstimates.Length / 2];

            for (int j = 0; j < fullProbabilitiesValues.Length; j++)
            {
                profits[0] += fullProbabilitiesValues[j] * maximumOfQuantativeEstimates[j];
            }

            // Ръчно сетване стойността на печалбата без провеждане на експеримент E(K) = 0
            profits[1] = maximumOfQuantativeEstimates[maximumOfQuantativeEstimates.Length - 1];

            // Принтиране на печалбите μk
            Console.WriteLine();
            Console.WriteLine(Constants.ProfitsMessage);
            Utility.PrintArray(profits);

            // Изваждане цената на експеримента от общата печалба
            profits[0] -= priceOfExperiment;

            // Изчисляване на максималната печалба (Стъпка 7 и финална за конзолното приложение)
            var totalProfit = Math.Max(profits[0], profits[1]);

            // Принтиране на максималната печалба
            Console.WriteLine();
            Console.WriteLine(Constants.MaxProfitMessage);
            Console.WriteLine($"{totalProfit} ПЕ");

            // Принтиране на краен резултат
            string message = profits[0] > profits[1] ?
                Constants.MessageForExperiment : Constants.MessageWithoutExperiment;
            Console.WriteLine(message);
        }
    }
}
