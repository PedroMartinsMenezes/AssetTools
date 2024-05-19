namespace AssetTool
{
    [Location("void FMeshSectionInfoMap::Serialize(FArchive& Ar)")]
    public class FMeshSectionInfoMap
    {
        public Dictionary<TUInt32, FMeshSectionInfo> Map = [];

        public FMeshSectionInfoMap Move(Transfer transfer)
        {
            if (!Supports.CustomVer(FReleaseObjectVersion.Enums.UPropertryForMeshSectionSerialize)
                &&
                !Supports.CustomVer(FEditorObjectVersion.Enums.UPropertryForMeshSectionSerialize))
            {
                Map.Resize(transfer);
                foreach (var pair in Map)
                {
                    pair.Key.Move(transfer);
                    pair.Value.Move(transfer);
                }
            }
            return this;
        }
    }
}
