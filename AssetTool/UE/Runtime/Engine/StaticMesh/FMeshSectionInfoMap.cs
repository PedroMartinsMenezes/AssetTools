namespace AssetTool
{
    [Location("void FMeshSectionInfoMap::Serialize(FArchive& Ar)")]
    public class FMeshSectionInfoMap
    {
        public Dictionary<UInt32, FMeshSectionInfo> Map = [];

        public FMeshSectionInfoMap Read(BinaryReader reader)
        {
            if (!Supports.CustomVer(FReleaseObjectVersion.Enums.UPropertryForMeshSectionSerialize)
                &&
                !Supports.CustomVer(FEditorObjectVersion.Enums.UPropertryForMeshSectionSerialize))
            {
                int count = reader.ReadInt32();
                for (int i = 0; i < count; i++)
                {
                    UInt32 key = reader.ReadUInt32();
                    FMeshSectionInfo value = new FMeshSectionInfo().Read(reader);
                    Map.Add(key, value);
                }
            }
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
