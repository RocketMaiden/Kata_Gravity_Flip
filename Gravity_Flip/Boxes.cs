namespace Gravity_Flip
{
    public class Boxes
    {
        private int[,] boxes;
        private int width;
        private int height;
        private int[] boxes_horisontal;
        private int[] boxes_vertical;


        public Boxes(int[] input_boxes_vertical)
        {
            width = input_boxes_vertical.Length;
            height = input_boxes_vertical.Max();
            boxes_horisontal = new int[height];
            boxes_vertical = new int[width];

            this.boxes = new int [width, height];
            
            for (int i = 0; i < width; i++)
            {
                for (int j = height - input_boxes_vertical[i]; j < height; j++)
                {
                    this.boxes[i, j] = 1;
                }
            }
        }

        public int[] HorisontalBoxes(int[,] boxes)
        {
            int count = 0;

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (boxes[i, j] == 1)
                    {
                        count++;
                    }
                }
                boxes_horisontal[j] = count;
                count = 0;
            }
                return boxes_horisontal;
        }

        public int[] VerticalBoxes(int[,] boxes)
        {
            int count = 0;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (boxes[i, j] == 1)
                    {
                        count++;
                    }
                }
                boxes_vertical[i] = count;
                count = 0;
            }
            return boxes_vertical;
        }

        public int[,] MoveRight()
        {
            int[,] boxesRight = new int[width, height];

            for (int j = 0; j < height; j++)
            {
                for (int i = width - boxes_horisontal[j]; i < width; i++)
                {
                    boxesRight[i, j] = 1;
                }
            }
            return boxesRight;
        }

        public int[,] MoveLeft()
        {
            int[,] boxesLeft = new int[width, height];

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < boxes_horisontal[j]; i++)
                {
                    boxesLeft[i, j] = 1;
                }
            }
            return boxesLeft;
        }

        public void ShowBoxes(int[,] boxesToShow)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write(boxesToShow[i, j]);
                }
                Console.WriteLine();
            }
        }

        public int[,] GetBoxes()
        {
            return boxes;
        }
    }
}
