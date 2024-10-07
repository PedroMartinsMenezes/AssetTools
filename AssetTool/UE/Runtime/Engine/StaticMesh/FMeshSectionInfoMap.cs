namespace AssetTool
{
    public class FMeshSectionInfoMap
    {
        public Dictionary<TUInt32, FMeshSectionInfo> Map = [];

        [Location("void FMeshSectionInfoMap::Serialize(FArchive& Ar)")]
        public FMeshSectionInfoMap Move(Transfer transfer)
        {
            if (!Supports.CustomVer(FReleaseObjectVersion.Enums.UPropertryForMeshSectionSerialize)
                &&
                !Supports.CustomVer(FEditorObjectVersion.Enums.UPropertryForMeshSectionSerialize))
            {
                Map.Move(transfer, (key) => key.Move(transfer), (value) => value.Move(transfer));
            }
            return this;
        }
    }
}
