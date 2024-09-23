namespace AssetTool
{
    public class FBoxSphereBounds3d
    {
        public const string StructName = "BoxSphereBounds3d";

        public FVector3d Origin = new();
        public FVector3d BoxExtent = new();
        public double SphereRadius;

        public void Move(Transfer transfer)
        {
            Origin.Move(transfer);
            BoxExtent.Move(transfer);
            transfer.Move(ref SphereRadius);
        }
    }

    public class FBoxSphereBounds3f
    {
        public const string StructName = "BoxSphereBounds3f";

        public FVector3f Origin = new();
        public FVector3f BoxExtent = new();
        public float SphereRadius;

        public void Move(Transfer transfer)
        {
            Origin.Move(transfer);
            BoxExtent.Move(transfer);
            transfer.Move(ref SphereRadius);
        }
    }
}
