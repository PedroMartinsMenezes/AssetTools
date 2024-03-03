namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    public class UMaterialEditorOnlyData : UMaterialInterfaceEditorOnlyData
    {
        public new const string TypeName = "MaterialEditorOnlyData";
    }

    public static class MaterialEditorOnlyDataExt
    {
        public static void Write(this BinaryWriter writer, UMaterialEditorOnlyData item)
        {
            writer.Write((UMaterialInterfaceEditorOnlyData)item);
        }

        public static UMaterialEditorOnlyData Read(this BinaryReader reader, UMaterialEditorOnlyData item)
        {
            reader.Read((UMaterialInterfaceEditorOnlyData)item);

            return item;
        }
    }
}
