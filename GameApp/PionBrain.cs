

namespace GameApp
{
    internal class PionBrain:Command
    {
        private Operations _operation;
        private Pion _pawn;

        public PionBrain(Pion calculator, Operations operation)
        {
            _pawn = calculator;
            _operation = operation;
        }

        public override void Execute()
        {
            _pawn.Move(_operation);
        }

        public override void UnExecute()
        {
            _pawn.Move(UndoOperation(_operation));
        }

        private Operations UndoOperation(Operations operation)
        {
            switch (operation)
            {
                case Operations.Up:
                    return Operations.Down;
                case Operations.Down:
                    return Operations.Up;
                case Operations.Right:
                    return Operations.Left;
                case Operations.Left:
                    return Operations.Right;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }
    }
}
