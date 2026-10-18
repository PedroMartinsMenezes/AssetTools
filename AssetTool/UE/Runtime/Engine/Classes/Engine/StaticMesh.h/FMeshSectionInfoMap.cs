namespace AssetTool
{
    public class FMeshSectionInfoMap : ITransferable
    {
        public Dictionary<TUInt32, FMeshSectionInfo> Map;

        [Location("void FMeshSectionInfoMap::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.FEditorObjectVersion_UPropertryForMeshSectionSerialize && !transfer.Supports.FReleaseObjectVersion_UPropertryForMeshSectionSerialize)
            {
                transfer.Move(ref Map);
            }
            return this;
        }
    }
}
