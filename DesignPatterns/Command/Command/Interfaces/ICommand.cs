namespace Command.Interfaces
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}
