namespace AssetTool.Chaos
{
    public class TUniformGrid3 : ITransferible
    {
        public TVector3 MMinCorner;
        public TVector3 MMaxCorner;
        public TVector3i MCells;
        public TVector3 MDx;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref MMinCorner);
            transfer.Move(ref MMaxCorner);
            transfer.Move(ref MCells);
            transfer.Move(ref MDx);
            return this;
        }
    }
}
