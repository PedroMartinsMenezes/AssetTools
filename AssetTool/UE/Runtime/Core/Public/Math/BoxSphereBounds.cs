namespace AssetTool
{
    public class FBoxSphereBounds3d : ITransferible
    {
        public FVector3d Origin = new();
        public FVector3d BoxExtent = new();
        public double SphereRadius;

        public ITransferible Move2(Transfer transfer)
        {
            Origin.Move2(transfer);
            BoxExtent.Move2(transfer);
            transfer.MoveSingleOrDouble(ref SphereRadius);
            return this;
        }
    }

    public class FBoxSphereBounds3f : ITransferible
    {
        public FVector3f Origin = new();
        public FVector3f BoxExtent = new();
        public float SphereRadius;

        public ITransferible Move2(Transfer transfer)
        {
            Origin.Move2(transfer);
            BoxExtent.Move2(transfer);
            transfer.Move(ref SphereRadius);
            return this;
        }
    }

    public class FBoxSphereBounds : ITransferible
    {
        public FVector3 Origin = new();
        public FVector3 BoxExtent = new();
        public double SphereRadius;

        public ITransferible Move2(Transfer transfer)
        {
            Origin.Move2(transfer);
            BoxExtent.Move2(transfer);
            transfer.MoveSingleOrDouble(ref SphereRadius);
            return this;
        }
    }
}
