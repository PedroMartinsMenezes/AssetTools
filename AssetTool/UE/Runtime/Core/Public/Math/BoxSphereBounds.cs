using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("({Origin} {BoxExtent} {SphereRadius})")]
    public class FBoxSphereBounds3d : ITransferable
    {
        public FVector3d Origin;
        public FVector3d BoxExtent;
        public double SphereRadius;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref BoxExtent);
            transfer.MoveSingleOrDouble(ref SphereRadius);
            return this;
        }
    }

    [DebuggerDisplay("({Origin} {BoxExtent} {SphereRadius})")]
    public class FBoxSphereBounds3f : ITransferable
    {
        public FVector3f Origin;
        public FVector3f BoxExtent;
        public float SphereRadius;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref BoxExtent);
            transfer.Move(ref SphereRadius);
            return this;
        }
    }

    [DebuggerDisplay("({Origin} {BoxExtent} {SphereRadius})")]
    public class FBoxSphereBounds : ITransferable
    {
        public FVector Origin;
        public FVector BoxExtent;
        public double SphereRadius;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref BoxExtent);
            transfer.MoveSingleOrDouble(ref SphereRadius);
            return this;
        }
    }
}
