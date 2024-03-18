namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    public class UMaterialInterfaceEditorOnlyData : UObject
    {
        public const string TypeName = "MaterialInterfaceEditorOnlyData";

        public FBool bSavedCachedExpressionData;

        public new UMaterialInterfaceEditorOnlyData Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref bSavedCachedExpressionData);
            if (bSavedCachedExpressionData.Value)
            {
                throw new NotImplementedException();
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(bSavedCachedExpressionData);
            if (bSavedCachedExpressionData.Value)
            {
                throw new NotImplementedException();
            }
        }
    }
}
