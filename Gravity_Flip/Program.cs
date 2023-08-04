using Gravity_Flip;

Console.WriteLine("This is a box moving simulation");

Boxes boxes = new Boxes(new int[] { 3, 2, 1, 2 });
boxes.ShowBoxes();

int[] horisontal_boxes_beforeGravityMove = boxes.HorisontalBoxes();
Console.WriteLine("Here are counted boxes in each horisontal row:");

foreach (int item in horisontal_boxes_beforeGravityMove)
{
    Console.Write($"{item}, ");
}

Console.WriteLine();



boxes.ShowBoxes();

Console.WriteLine();
Console.ReadKey();