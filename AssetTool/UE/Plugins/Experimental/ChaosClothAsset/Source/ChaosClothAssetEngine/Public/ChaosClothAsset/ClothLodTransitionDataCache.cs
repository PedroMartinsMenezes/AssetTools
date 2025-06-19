namespace AssetTool
{
    [TransferibleStruct("ChaosClothAssetLodTransitionDataCache")]
    public class FChaosClothAssetLodTransitionDataCache : ITransferible
    {
        public UScriptStruct Struct = new();
        public FMD5Hash ModelHash;
        public List<FMeshToMeshVertData> LODTransitionUpData;
        public List<FMeshToMeshVertData> LODTransitionDownData;

        [Location("bool FChaosClothAssetLodTransitionDataCache::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            Struct.SerializeTaggedProperties(transfer);
            transfer.Move(ref ModelHash);
            transfer.Move(ref LODTransitionUpData);
            transfer.Move(ref LODTransitionDownData);
            return this;
        }
    }
}