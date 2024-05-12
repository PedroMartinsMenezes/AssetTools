namespace AssetTool
{
    [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
    public class UMaterialInstance : UMaterialInterface
    {
        public FBool bSavedCachedData;
        public UInt32 NumLoadedResources;

        public new UMaterialInstance Read(BinaryReader reader)
        {
            var transfer = GlobalObjects.Transfer;
            base.Read(reader);

            if (Supports.MaterialSavedCachedData)
                transfer.Move(ref bSavedCachedData);

            if (bSavedCachedData?.Value == true)
                throw new NotImplementedException();

            if (GlobalNames.Contains("bHasStaticPermutationResource"))
            {
                transfer.Move(ref NumLoadedResources);

                if (NumLoadedResources > 0)
                    throw new NotImplementedException();
            }
            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            base.Write(writer);

            if (Supports.MaterialSavedCachedData)
                transfer.Move(bSavedCachedData);

            if (bSavedCachedData?.Value == true)
                throw new NotImplementedException();

            if (GlobalNames.Contains("bHasStaticPermutationResource"))
            {
                transfer.Move(NumLoadedResources);

                if (NumLoadedResources > 0)
                    throw new NotImplementedException();
            }
        }
    }
}
