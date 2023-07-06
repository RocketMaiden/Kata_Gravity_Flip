namespace Gravity_Flip
{
    public class Boxes
    {
        private int[,] boxes_vertical;

        public Boxes(int[] boxes_vertical)
        {
            this.boxes_vertical = new int [boxes_vertical.Length - 1 , boxes_vertical.Max()];
        }
    }
}
