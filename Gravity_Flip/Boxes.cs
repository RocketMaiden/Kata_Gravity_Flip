namespace Gravity_Flip
{
    public class Boxes
    {
        private int[,] boxes;
        int width;
        int height;
        

        public Boxes(int[] input_boxes_vertical)
        {
            width = input_boxes_vertical.Length;
            height = input_boxes_vertical.Max();

            this.boxes = new int [width, height];
            
            for (int i = 0; i < width; i++)
            {
                //if (input_boxes_vertical[i] != 0)
                {
                    for (int j = height - input_boxes_vertical[i]; j < height; j++)
                    {
                        this.boxes[i, j] = 1;
                    }
                }
            }
        }

        public int [] HorisontalBoxes()
        {
            int[] boxes_horisontal = new int[width];

            for (int i = 0; i < width; i++)
            {
                int count = 0;

                for (int j = 0; j < height; j++)
                {
                    if (boxes[i, j] == 1)
                    {
                        count++;
                    }
                    boxes_horisontal[j] = count;//
                }
            }
            return boxes_horisontal;
        }

        public void MoveRight()
        {

        }

        public void MoveLeft()
        {

        }

        public void ShowBoxes()
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write(boxes[i, j]);
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
