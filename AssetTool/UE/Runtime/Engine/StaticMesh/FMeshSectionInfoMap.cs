namespace AssetTool
{
    public class FMeshSectionInfoMap : ITransferible
    {
        public Dictionary<TUInt32, FMeshSectionInfo> Map;

        [Location("void FMeshSectionInfoMap::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.UPropertryForMeshSectionSerialize)
            {
                transfer.Move(ref Map);
            }
            return this;
        }
    }
}
