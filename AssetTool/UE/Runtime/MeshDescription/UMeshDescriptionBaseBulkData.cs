namespace AssetTool
{
    [Location("void UMeshDescriptionBaseBulkData::Serialize(FArchive& Ar)")]
    public class UMeshDescriptionBaseBulkData : UObject
    {
        public FMeshDescriptionBulkData BulkData;

        public UMeshDescriptionBaseBulkData Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);
            BulkData = new FMeshDescriptionBulkData().Read(reader);
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);
            BulkData.Write(writer);
        }
    }
}
