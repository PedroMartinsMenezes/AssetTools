using System.Diagnostics;

namespace AssetTool.Chaos
{
    [DebuggerDisplay("Min{MMin} Max{MMax}")]
    public class TAABB3 : ITransferible
    {
        public TVector3 MMin;
        public TVector3 MMax;

        [Location("inline FArchive& SerializeReal(FArchive& Ar, TVector<T, d>& ValueIn)")]
        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref MMin);
            transfer.Move(ref MMax);
            return this;
        }
    }
}
