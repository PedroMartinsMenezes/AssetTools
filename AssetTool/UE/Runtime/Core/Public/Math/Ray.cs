using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("Origin{Origin} Direction{Direction})")]
    public class FRay3d : ITransferable
    {
        public FVector3d Origin;
        public FVector3d Direction;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref Direction);
            return this;
        }
    }

    [DebuggerDisplay("Origin{Origin} Direction{Direction})")]
    public class FRay3f : ITransferable
    {
        public FVector3f Origin;
        public FVector3f Direction;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref Direction);
            return this;
        }
    }

    [DebuggerDisplay("Origin{Origin} Direction{Direction})")]
    public class FRay : ITransferable
    {
        public FVector Origin;
        public FVector Direction;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref Direction);
            return this;
        }
    }
}
