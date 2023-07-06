namespace Gravity_Flip
{
    public class Boxes
    {
        private int[,] boxes_vertical;
        int width;
        int height;

        public Boxes(int[] input_boxes_vertical)
        {
            height = input_boxes_vertical.Length;
            width = input_boxes_vertical.Max();

            this.boxes_vertical = new int [width, height];

            /*for (int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if (input_boxes_vertical[j] != 0)
                    {
                        this.boxes_vertical[i, (height - input_boxes_vertical[i])] = 1;
                    }
                }
            }*/
        }

        public void ShowRawBoxes()
        {
            for(int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(boxes_vertical[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
