namespace AssetTool
{
    public interface ITransferable
    {
        ITransferable Move(Transfer transfer);
    }

    public interface ITransferableRaw
    {
        ITransferable MoveRaw(Transfer transfer);
    }

    public interface ITransferable<in T1> : ITransferable
    {
        ITransferable Move(Transfer transfer, T1 arg1);
    }

    public interface ITransferable<in T1, in T2> : ITransferable
    {
        ITransferable Move(Transfer transfer, T1 arg1, T2 arg2);
    }

    public interface ITransferable<in T1, in T2, in T3> : ITransferable
    {
        ITransferable Move(Transfer transfer, T1 arg1, T2 arg2, T3 arg3);
    }

    public interface ITransferableSelector : ITransferable
    {
        object Move(Transfer transfer, int num, object value);
    }

    public interface ITransferablePropertyTag : ITransferable
    {
        bool IsPropertyTag(Transfer transfer);
    }
}
