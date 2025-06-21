namespace AssetTool
{
    public class FPlane4d : ITransferible
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FPlane4f : ITransferible
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FPlane : ITransferible
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.LARGE_WORLD_COORDINATES)
            {
                transfer.Move(ref X);
                transfer.Move(ref Y);
                transfer.Move(ref Z);
                transfer.Move(ref W);
            }
            else
            {
                X = transfer.Move((float)X);
                Y = transfer.Move((float)Y);
                Z = transfer.Move((float)Z);
                W = transfer.Move((float)W);
            }
            return this;
        }
    }
}
