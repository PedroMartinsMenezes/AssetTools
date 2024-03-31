namespace AssetTool
{
    [Location("void UMeshDescriptionBaseBulkData::Serialize(FArchive& Ar)")]
    public class UMeshDescriptionBaseBulkData : UObject
    {
        public FMeshDescriptionBulkData BulkData;

        public UMeshDescriptionBaseBulkData Read(BinaryReader reader)
        {
            base.Read(reader);
            BulkData = new FMeshDescriptionBulkData().Read(reader); //14063
            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            BulkData.Write(writer);
        }
    }
}
