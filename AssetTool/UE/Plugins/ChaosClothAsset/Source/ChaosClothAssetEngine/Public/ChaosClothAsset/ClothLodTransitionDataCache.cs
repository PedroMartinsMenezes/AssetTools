namespace AssetTool
{
    [TransferableStruct("ChaosClothAssetLodTransitionDataCache")]
    public class FChaosClothAssetLodTransitionDataCache : ITransferable
    {
        public UScriptStruct Struct = new();
        public FMD5Hash ModelHash;
        public List<FMeshToMeshVertData> LODTransitionUpData;
        public List<FMeshToMeshVertData> LODTransitionDownData;

        [Location("bool FChaosClothAssetLodTransitionDataCache::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            Struct.SerializeTaggedProperties(transfer);
            transfer.Move(ref ModelHash);
            transfer.Move(ref LODTransitionUpData);
            transfer.Move(ref LODTransitionDownData);
            return this;
        }
    }
}