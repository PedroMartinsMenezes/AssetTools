namespace AssetTool
{
    public class FSphere3d : ITransferible
    {
        public FVector3d Center;
        public double W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Center);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FSphere3f : ITransferible
    {
        public FVector3f Center;
        public float W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Center);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FSphere : ITransferible
    {
        public FVector Center;
        public double W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Center);
            transfer.MoveSingleOrDouble(ref W);
            return this;
        }
    }
}
