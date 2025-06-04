namespace AssetTool.Chaos
{
    public class TAABB3 : ITransferible
    {
        public TVector3 MMin;
        public TVector3 MMax;

        [Location("inline FArchive& SerializeReal(FArchive& Ar, TVector<T, d>& ValueIn)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref MMin);
            transfer.Move(ref MMax);
            return this;
        }
    }
}
