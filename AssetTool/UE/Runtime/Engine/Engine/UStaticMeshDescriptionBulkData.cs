namespace AssetTool
{
    public class UStaticMeshDescriptionBulkData : UMeshDescriptionBaseBulkData
    {
        public const string TypeName = "StaticMeshDescriptionBulkData";

        public new UStaticMeshDescriptionBulkData Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
