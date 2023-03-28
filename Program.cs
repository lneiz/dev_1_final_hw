
void Main()
{
    Console.Write("Сколько элементов массива планируете ввести? ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значения элементов массива построчно через Enter. Наберите 'end', чтобы завершить ввод: " + "\r\n");
    string[] inputArray = new string[size];
    string[] resultArray = new string[size];
    int j = 0; int k = 0;
    for(int i = 0; i < size; i++)
    {
        string inputLine = Console.ReadLine();
        if(inputLine != "end")
        {
            inputArray[i] = inputLine;
            j++;

            if(inputArray[i].Length <= 3)
            {
                resultArray[k] = inputArray[i];
                k++;
            }
        } 
        else
        {
            while(i < size)
            {
                i++;
            }
        }
    }
    Array.Resize(ref inputArray, j);
    Array.Resize(ref resultArray, k);

    Console.Write($"{OutputAction(inputArray)} -> {OutputAction(resultArray)}");
}

string OutputAction(string[] array)
{
    string result = "[" + string.Join(", ", array) + "]";
    return result;
}

Main();