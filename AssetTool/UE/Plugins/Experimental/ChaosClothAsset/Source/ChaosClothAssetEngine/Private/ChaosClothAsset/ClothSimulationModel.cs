namespace AssetTool
{
    [TransferibleStruct("ChaosClothSimulationLodModel")]
    public class FChaosClothSimulationLodModel : ITransferible
    {
        public UScriptStruct Struct = new();
        public bool bCooked;
        public Dictionary<FName, List<TFloat>> WeightMaps;
        public List<FMeshToMeshVertData> LODTransitionUpData;
        public List<FMeshToMeshVertData> LODTransitionDownData;
        public Dictionary<FName, List<TInt32>> VertexSets;
        public Dictionary<FName, List<TInt32>> FaceIntMaps;
        public Dictionary<FName, List<TInt32>> FaceSets;

        [Location("bool FChaosClothSimulationLodModel::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            Struct.SerializeTaggedProperties(transfer);
            transfer.Move(ref bCooked);
            transfer.Move(ref WeightMaps);
            transfer.Move(ref LODTransitionUpData);
            transfer.Move(ref LODTransitionDownData);
            transfer.Move(ref VertexSets);
            transfer.Move(ref FaceIntMaps);
            transfer.Move(ref FaceSets);
            return this;
        }
    }
}