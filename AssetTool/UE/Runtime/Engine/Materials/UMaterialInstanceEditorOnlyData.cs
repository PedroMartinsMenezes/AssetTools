namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    public class UMaterialInstanceEditorOnlyData : UMaterialInterfaceEditorOnlyData
    {
        public new const string TypeName = "MaterialInstanceEditorOnlyData";
    }

    public static class UMaterialInstanceEditorOnlyDataExt
    {
        public static void Write(this BinaryWriter writer, UMaterialInstanceEditorOnlyData item)
        {
            writer.Write((UMaterialInterfaceEditorOnlyData)item);
        }

        public static UMaterialInstanceEditorOnlyData Read(this BinaryReader reader, UMaterialInstanceEditorOnlyData item)
        {
            reader.Read((UMaterialInterfaceEditorOnlyData)item);

            return item;
        }
    }
}
