namespace AssetTool
{
    [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
    public class UMaterialInstance : UMaterialInterface
    {
        public FBool bSavedCachedData;

        public UInt32 NumLoadedResources;
    }

    public static class UMaterialInstanceExt
    {
        public static void Write(this BinaryWriter writer, UMaterialInstance item)
        {
            writer.Write((UMaterialInterface)item);

            if (Supports.MaterialSavedCachedData)
                writer.Write(item.bSavedCachedData);

            if (item.bSavedCachedData?.Value == true)
                throw new NotImplementedException();

            if (GlobalNames.Contains("bHasStaticPermutationResource"))
            {
                writer.Write(item.NumLoadedResources);

                if (item.NumLoadedResources > 0)
                    throw new NotImplementedException();
            }
        }

        public static UMaterialInstance Read(this BinaryReader reader, UMaterialInstance item)
        {
            reader.Read((UMaterialInterface)item);

            if (Supports.MaterialSavedCachedData)
                reader.Read(ref item.bSavedCachedData);

            if (item.bSavedCachedData?.Value == true)
                throw new NotImplementedException();

            if (GlobalNames.Contains("bHasStaticPermutationResource"))
            {
                reader.Read(ref item.NumLoadedResources);

                if (item.NumLoadedResources > 0)
                    throw new NotImplementedException();
            }
            return item;
        }
    }
}
