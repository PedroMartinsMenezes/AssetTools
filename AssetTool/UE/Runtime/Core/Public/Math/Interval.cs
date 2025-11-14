namespace AssetTool
{
    public class FFloatInterval : ITransferable
    {
        public float Min;
        public float Max;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            return this;
        }
    }

    public class FInt32Interval : ITransferable
    {
        public int32 Min;
        public int32 Max;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            return this;
        }
    }
}
