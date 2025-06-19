namespace AssetTool
{
    public class FSphere3d : ITransferible
    {
        public FVector3d Center;
        public double W;

        public ITransferible Move2(Transfer transfer)
        {
            Center.Move2(transfer);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FSphere3f : ITransferible
    {
        public FVector3f Center;
        public float W;

        public ITransferible Move2(Transfer transfer)
        {
            Center.Move2(transfer);
            transfer.Move(ref W);
            return this;
        }
    }
}
