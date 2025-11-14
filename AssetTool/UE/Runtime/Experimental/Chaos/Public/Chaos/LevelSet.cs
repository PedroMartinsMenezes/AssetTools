namespace AssetTool.Chaos
{
    public class FLevelSet : FImplicitObject
    {
        public TUniformGrid3 MGrid;
        public FVec3[] MPhi = [new(), new(), new()];
        public FVec3[] MNormals = [new(), new(), new()];
        public int32 MBandWidth;

        [Location("FORCEINLINE void SerializeImp(FArchive& Ar) at 77")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MGrid);
            transfer.Move(ref MPhi, MPhi.Length);
            transfer.Move(ref MNormals, MNormals.Length);
            transfer.Move(ref MBandWidth);
            return this;
        }
    }
}
