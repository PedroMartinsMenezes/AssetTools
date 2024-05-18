namespace AssetTool
{
    [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
    public class UMaterialInstance : UMaterialInterface
    {
        public FBool bSavedCachedData;
        public UInt32 NumLoadedResources;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

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
    }
}
