using Gravity_Flip;

Console.WriteLine("This is a box moving simulation");

Boxes boxes = new Boxes(new int[] { 3, 2, 1, 2 });
int[,] originalBoxes = boxes.GetBoxes();
boxes.ShowBoxes(originalBoxes);

Console.WriteLine();

Console.WriteLine("Here are counted boxes in each horisontal row:");
int[] horisontal_boxes_beforeGravityMove = boxes.HorisontalBoxes(originalBoxes);

foreach (int item in horisontal_boxes_beforeGravityMove)
{
    Console.Write($"{item} ");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Let's move them to the right");
int[,] boxes_after_gravity_right = boxes.MoveRight();
boxes.ShowBoxes(boxes_after_gravity_right);

Console.WriteLine();

Console.WriteLine("Here are counted boxes in each vertical row after gravity move:");
int[] boxes_in_vertical_columns = boxes.VerticalBoxes(boxes_after_gravity_right);
foreach(int item in boxes_in_vertical_columns)
{
    Console.Write($"{item} ");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Let's move them to the left");
int[,] boxes_after_gravity_left = boxes.MoveLeft();
boxes.ShowBoxes(boxes_after_gravity_left);

Console.WriteLine();

Console.WriteLine("Here are counted boxes in each vertical row after gravity move:");
int[] boxes_in_vertical_columns2 = boxes.VerticalBoxes(boxes_after_gravity_left);
foreach (int item in boxes_in_vertical_columns2)
{
    Console.Write($"{item} ");
}

Console.WriteLine();
Console.ReadKey();