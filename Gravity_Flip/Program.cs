using Gravity_Flip;

Console.WriteLine("This is a box moving simulation");

Boxes boxes = new Boxes(new int[] { 3, 2, 1, 2 });

boxes.ShowRawBoxes();

Console.WriteLine();
Console.ReadKey();

int number = 1813;
int length = 0;
int[] number_array;

while(number%10 > 0)
{
    //int letter = number / 10;
    number = number % 10;
    length++;
}

number_array = new int[length];

while(number % 10 > 0)
{
    number_array[number % 10] = number / 10;
    number = number % 10;
}
int sum = 0;

foreach (int letter in number_array)
{
    sum += letter;
}