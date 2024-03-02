namespace AssetTool
{
    [Location("v")]
    public class UMaterialInstanceConstant : UMaterialInstance
    {
        public const string TypeName = "MaterialInstanceConstant";
    }

    public static class UMaterialInstanceConstantExt
    {
        public static void Write(this BinaryWriter writer, UMaterialInstanceConstant item)
        {
            writer.Write((UMaterialInstance)item);
        }

        public static UMaterialInstanceConstant Read(this BinaryReader reader, UMaterialInstanceConstant item)
        {
            reader.Read((UMaterialInstance)item);
            return item;
        }
    }
}
