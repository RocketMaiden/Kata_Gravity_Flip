﻿using Gravity_Flip;

Console.WriteLine("This is a box moving simulation");

Boxes boxes = new Boxes(new int[] { 3, 2, 1, 2 });
int[,] originalBoxes = boxes.GetBoxes();
boxes.ShowBoxes(originalBoxes);

Console.WriteLine();

int[] horisontal_boxes_beforeGravityMove = boxes.HorisontalBoxes();
Console.WriteLine("Here are counted boxes in each horisontal row:");

foreach (int item in horisontal_boxes_beforeGravityMove)
{
    Console.Write($"{item} ");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Let's move them to right");
boxes.ShowBoxes(boxes.MoveRight());

Console.WriteLine();

boxes.ShowBoxes(boxes.MoveLeft());

Console.WriteLine();
Console.ReadKey();