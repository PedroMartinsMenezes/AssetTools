namespace AssetTool
{
    [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
    public class UMaterialInstance : UMaterialInterface
    {
        public FBool bSavedCachedData;
        public UInt32 NumLoadedResources;

        public new UMaterialInstance Read(BinaryReader reader)
        {
            base.Read(reader);

            if (Supports.MaterialSavedCachedData)
                reader.Read(ref bSavedCachedData);

            if (bSavedCachedData?.Value == true)
                throw new NotImplementedException();

            if (GlobalNames.Contains("bHasStaticPermutationResource"))
            {
                reader.Read(ref NumLoadedResources);

                if (NumLoadedResources > 0)
                    throw new NotImplementedException();
            }
            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);

            if (Supports.MaterialSavedCachedData)
                writer.Write(bSavedCachedData);

            if (bSavedCachedData?.Value == true)
                throw new NotImplementedException();

            if (GlobalNames.Contains("bHasStaticPermutationResource"))
            {
                writer.Write(NumLoadedResources);

                if (NumLoadedResources > 0)
                    throw new NotImplementedException();
            }
        }
    }
}
