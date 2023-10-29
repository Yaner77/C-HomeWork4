// №1
    int Prompt (string message)
{ 
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] InputArray (int length)
{
    int [] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент");
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a [{i}] = {array[i]}");
    }
}
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int lenght = Prompt ("Введите количество элементов >");
int[] array; 
array = InputArray (lenght); 
PrintArray(array); 
System.Console.WriteLine($"Количество числе больше 0 - {CountPositiveNumbers(array)}");


// №2
const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);
if(ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    System.Console.WriteLine($"Точка пересечения уравнений y={lineData1[COEFFICIENT]}*x+{lineData1[CONSTANT]} и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]}");
    System.Console.WriteLine($" имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
}
double Prompt(string message)
{
     System.Console.WriteLine(message);
     string value = Console.ReadLine();
     double result = Convert.ToDouble(value);
     return result;
}
double[] InputLineData(int numbersOfLine)
{ 
    double[] LineData = new double [2];
    LineData [COEFFICIENT] = Prompt($"Введите коэффициент для {numbersOfLine} прямой > ");
    LineData [CONSTANT] = Prompt($"Введите константу для {numbersOfLine} прямой > ");
    return LineData;
}
double[] FindCoords (double[] lineData1, double[] lineData2)
{ 
    double[] coord = new double[2];
    coord [X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coord [Y_COORD] = (lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT]);
    return coord;
}
bool ValidateLines (double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
             System.Console.WriteLine("Прямые параллельны");
             return false;
        }
    }
    return true;
}