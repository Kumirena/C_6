/* Пользователь вводит с клавиатуры М чисел. 
Посчитате, сколько чисел больше 0 ввел пользователь.
*/

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine($"количество значений больше 0 = {sum}");

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temporary = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temporary += input[i].ToString();
                i++;
            }
            else
            {
                temporary += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temporary);
        index++;
    }
    return numbers;
}










