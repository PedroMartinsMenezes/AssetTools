namespace AssetTool
{
    [Location("void UMaterialInterface::Serialize(FArchive& Ar)")]
    public class UMaterialInterface : UObject
    {
        public FBool bSavedCachedExpressionData;
    }

    public static class UMaterialInterfaceExt
    {
        public static void Write(this BinaryWriter writer, UMaterialInterface item)
        {
            writer.Write((UObject)item);

            if (Supports.MaterialInterfaceSavedCachedData)
                writer.Write(item.bSavedCachedExpressionData);

            if (item.bSavedCachedExpressionData?.Value == true)
            {
                throw new NotImplementedException();
            }
        }

        public static UMaterialInterface Read(this BinaryReader reader, UMaterialInterface item)
        {
            reader.Read((UObject)item);

            if (Supports.MaterialInterfaceSavedCachedData)
                reader.Read(ref item.bSavedCachedExpressionData);

            if (item.bSavedCachedExpressionData?.Value == true)
            {
                throw new NotImplementedException();
            }

            return item;
        }
    }
}
