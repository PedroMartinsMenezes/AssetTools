namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    public class UMaterialInterfaceEditorOnlyData : UObject
    {
        public const string TypeName = "MaterialInterfaceEditorOnlyData";

        public FBool bSavedCachedExpressionData;
    }

    public static class UMaterialInterfaceEditorOnlyDataExt
    {
        public static void Write(this BinaryWriter writer, UMaterialInterfaceEditorOnlyData item)
        {
            writer.Write((UObject)item);

            writer.Write(item.bSavedCachedExpressionData);
        }

        public static UMaterialInterfaceEditorOnlyData Read(this BinaryReader reader, UMaterialInterfaceEditorOnlyData item)
        {
            reader.Read((UObject)item);

            reader.Read(ref item.bSavedCachedExpressionData);

            if (item.bSavedCachedExpressionData.Value)
            {
                throw new NotImplementedException();
            }

            return item;
        }
    }
}
