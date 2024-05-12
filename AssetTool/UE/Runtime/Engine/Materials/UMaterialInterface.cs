namespace AssetTool
{
    [Location("void UMaterialInterface::Serialize(FArchive& Ar)")]
    public class UMaterialInterface : UObject
    {
        public FBool bSavedCachedExpressionData;

        public UMaterialInterface Read(BinaryReader reader)
        {
            var transfer = GlobalObjects.Transfer;
            base.Read(reader);
            if (Supports.MaterialInterfaceSavedCachedData)
                transfer.Move(ref bSavedCachedExpressionData);
            if (bSavedCachedExpressionData?.Value == true)
            {
                throw new NotImplementedException();
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            base.Write(writer);
            if (Supports.MaterialInterfaceSavedCachedData)
                transfer.Move(bSavedCachedExpressionData);

            if (bSavedCachedExpressionData?.Value == true)
            {
                throw new NotImplementedException();
            }
        }
    }
}
