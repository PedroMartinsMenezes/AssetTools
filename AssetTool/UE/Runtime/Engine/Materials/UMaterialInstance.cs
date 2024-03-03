namespace AssetTool
{
    [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
    public class UMaterialInstance : UMaterialInterface
    {
        public FBool bSavedCachedData;
    }

    public static class UMaterialInstanceExt
    {
        public static void Write(this BinaryWriter writer, UMaterialInstance item)
        {
            writer.Write((UMaterialInterface)item);

            if (Supports.MaterialSavedCachedData)
                writer.Write(item.bSavedCachedData);

            if (item.bSavedCachedData?.Value == true)
            {
                throw new NotImplementedException();
            }
        }

        public static UMaterialInstance Read(this BinaryReader reader, UMaterialInstance item)
        {
            reader.Read((UMaterialInterface)item);

            if (Supports.MaterialSavedCachedData)
                reader.Read(ref item.bSavedCachedData);

            if (item.bSavedCachedData?.Value == true)
            {
                throw new NotImplementedException();
            }

            return item;
        }
    }
}
