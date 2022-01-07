

namespace GameApp
{
    internal class chessTable
    {
        private readonly Pion pion;

        private readonly List<PionBrain> _commandHistory = new List<PionBrain>();

        public chessTable(Pion calculator)
        {
            pion = calculator;
        }

        public void ExecuteOperation(Operations operation)
        {
            var calcCommand = new PionBrain(pion, operation);
            calcCommand.Execute();
            _commandHistory.Add(calcCommand);
        }

        public void Undo()
        {
            var lastCommand = _commandHistory.LastOrDefault();
            if (lastCommand == null) return;

            lastCommand.UnExecute();
            _commandHistory.Remove(lastCommand);
        }

        public void Redo()
        {
            var lastCommand = _commandHistory.LastOrDefault();
            lastCommand?.Execute();
        }
    }
}
