namespace AssetTool
{
    public class FPlane4d : FVector3d
    {
        public double W;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FPlane4f : FVector3f
    {
        public float W;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FPlane : FVector
    {
        public double W;

        public FPlane() { }

        public FPlane(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                transfer.Move(ref W);
            }
            else
            {
                W = transfer.Move((float)W);
            }
            return this;
        }
    }
}
