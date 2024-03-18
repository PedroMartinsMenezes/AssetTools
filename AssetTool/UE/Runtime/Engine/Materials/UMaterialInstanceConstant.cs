namespace AssetTool
{
    [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
    public class UMaterialInstanceConstant : UMaterialInstance
    {
        public const string TypeName = "MaterialInstanceConstant";

        public new UMaterialInstanceConstant Read(BinaryReader reader)
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
