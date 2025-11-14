namespace AssetTool
{
    public class FSphere3d : ITransferable
    {
        public FVector3d Center;
        public double W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Center);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FSphere3f : ITransferable
    {
        public FVector3f Center;
        public float W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Center);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FSphere : ITransferable
    {
        public FVector Center;
        public double W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Center);
            transfer.MoveSingleOrDouble(ref W);
            return this;
        }
    }
}
