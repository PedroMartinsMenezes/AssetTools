namespace AssetTool
{
    public class FInterval1f : ITransferable
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

    public class FInterval1d : ITransferable
    {
        public double Min;
        public double Max;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref Max);
            return this;
        }
    }
}
