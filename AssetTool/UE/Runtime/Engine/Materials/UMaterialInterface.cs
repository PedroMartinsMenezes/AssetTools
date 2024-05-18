namespace AssetTool
{
    [Location("void UMaterialInterface::Serialize(FArchive& Ar)")]
    public class UMaterialInterface : UObject
    {
        public FBool bSavedCachedExpressionData;

        public override UObject Move(Transfer transfer)
        {
            base.Move(GlobalObjects.Transfer);
            if (Supports.MaterialInterfaceSavedCachedData)
                transfer.Move(ref bSavedCachedExpressionData);
            if (bSavedCachedExpressionData?.Value == true)
            {
                throw new NotImplementedException();
            }
            return this;
        }
    }
}
