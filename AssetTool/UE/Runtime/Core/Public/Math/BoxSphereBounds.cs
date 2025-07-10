using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("({Origin} {BoxExtent} {SphereRadius})")]
    public class FBoxSphereBounds3d : ITransferible
    {
        public FVector3d Origin;
        public FVector3d BoxExtent;
        public double SphereRadius;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref BoxExtent);
            transfer.MoveSingleOrDouble(ref SphereRadius);
            return this;
        }
    }

    [DebuggerDisplay("({Origin} {BoxExtent} {SphereRadius})")]
    public class FBoxSphereBounds3f : ITransferible
    {
        public FVector3f Origin;
        public FVector3f BoxExtent;
        public float SphereRadius;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref BoxExtent);
            transfer.Move(ref SphereRadius);
            return this;
        }
    }

    [DebuggerDisplay("({Origin} {BoxExtent} {SphereRadius})")]
    public class FBoxSphereBounds : ITransferible
    {
        public FVector3 Origin;
        public FVector3 BoxExtent;
        public double SphereRadius;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Origin);
            transfer.Move(ref BoxExtent);
            transfer.MoveSingleOrDouble(ref SphereRadius);
            return this;
        }
    }
}
