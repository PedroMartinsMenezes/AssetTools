namespace AssetTool
{
    public interface ITransferible
    {
        ITransferible Move(Transfer transfer);
    }

    public interface ITransferibleRaw
    {
        ITransferible MoveRaw(Transfer transfer);
    }

    public interface ITransferible<in T1> : ITransferible
    {
        ITransferible Move(Transfer transfer, T1 arg1);
    }

    public interface ITransferible<in T1, in T2> : ITransferible
    {
        ITransferible Move(Transfer transfer, T1 arg1, T2 arg2);
    }

    public interface ITransferible<in T1, in T2, in T3> : ITransferible
    {
        ITransferible Move(Transfer transfer, T1 arg1, T2 arg2, T3 arg3);
    }

    public interface ITransferibleSelector : ITransferible
    {
        object Move(Transfer transfer, int num, object value);
    }
}
