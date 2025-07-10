namespace AssetTool
{
    public class FFloatInterval : ITransferible
    {
        public float Min;
        public float Max;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            return this;
        }
    }

    public class FInt32Interval : ITransferible
    {
        public int32 Min;
        public int32 Max;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            return this;
        }
    }
}
