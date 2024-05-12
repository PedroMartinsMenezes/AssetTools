namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    public class UMaterialInterfaceEditorOnlyData : UObject
    {
        public const string TypeName = "MaterialInterfaceEditorOnlyData";

        public FBool bSavedCachedExpressionData;

        public UMaterialInterfaceEditorOnlyData Read(BinaryReader reader)
        {
            var transfer = GlobalObjects.Transfer;
            base.Read(reader);
            transfer.Move(ref bSavedCachedExpressionData);
            if (bSavedCachedExpressionData.Value)
            {
                throw new NotImplementedException();
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            base.Write(writer);
            transfer.Move(bSavedCachedExpressionData);
            if (bSavedCachedExpressionData.Value)
            {
                throw new NotImplementedException();
            }
        }
    }
}
