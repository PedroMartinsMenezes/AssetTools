namespace AssetTool
{
    public class FMeshSectionInfoMap
    {
        public Dictionary<TUInt32, FMeshSectionInfo> Map;

        [Location("void FMeshSectionInfoMap::Serialize(FArchive& Ar)")]
        public FMeshSectionInfoMap Move(Transfer transfer)
        {
            if (!Supports.UPropertryForMeshSectionSerialize)
            {
                transfer.Move(ref Map);
            }
            return this;
        }
    }
}
