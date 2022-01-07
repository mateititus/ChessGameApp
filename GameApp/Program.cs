

namespace GameApp

{
    class Program
    {
        static void Main(string[] args)
        {
            var pion = new Pion();
            var chessTable = new chessTable(pion);

            var pion2 = new Pion();
            var chessTable2 = new chessTable(pion2);

            chessTable.ExecuteOperation(Operations.Up);
            chessTable.ExecuteOperation(Operations.Up);
            chessTable.ExecuteOperation(Operations.Down);
            chessTable.ExecuteOperation(Operations.Right);
            chessTable.ExecuteOperation(Operations.Down);
            chessTable.ExecuteOperation(Operations.Left);

            chessTable.Undo();
            chessTable.Redo();


            Console.WriteLine("------------------");


            chessTable2.ExecuteOperation(Operations.Up);
            chessTable2.ExecuteOperation(Operations.Up);
            chessTable2.ExecuteOperation(Operations.Up);
            chessTable2.ExecuteOperation(Operations.Up);
            chessTable2.ExecuteOperation(Operations.Up);
            chessTable2.ExecuteOperation(Operations.Up);
            chessTable2.ExecuteOperation(Operations.Up);

            chessTable2.Undo();
            chessTable2.Undo();
            chessTable2.Redo();

            Console.ReadLine();
        }
    }
}
