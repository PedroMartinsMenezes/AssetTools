namespace AssetTool
{
    [Location("void UMaterialInterface::Serialize(FArchive& Ar)")]
    public class UMaterialInterface : UObject
    {
        public FBool bSavedCachedExpressionData;

        public new UMaterialInterface Read(BinaryReader reader)
        {
            base.Read(reader);
            if (Supports.MaterialInterfaceSavedCachedData)
                reader.Read(ref bSavedCachedExpressionData);
            if (bSavedCachedExpressionData?.Value == true)
            {
                throw new NotImplementedException();
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            if (Supports.MaterialInterfaceSavedCachedData)
                writer.Write(bSavedCachedExpressionData);

            if (bSavedCachedExpressionData?.Value == true)
            {
                throw new NotImplementedException();
            }
        }
    }
}
