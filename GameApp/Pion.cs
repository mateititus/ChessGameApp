namespace GameApp
{
    internal class Pion
    {
        private int limit = 8;
        private int heigth = 1;
        private int length;

        List<string> chessTable = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H" };

        public void Move(Operations operation)
        {

            switch (operation)
            {
                case Operations.Up: if (heigth < limit) heigth += 1; break;
                case Operations.Down: if (heigth > 1) heigth -= 1; break;
                case Operations.Right: if (length < limit) length += 1; break;
                case Operations.Left: if (length > 1) length -= 1; break;
            }
            Console.WriteLine($"Current value = {heigth}{chessTable[length]} (after {operation})");
        }
    }
}
