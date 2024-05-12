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
            base.Move(GlobalObjects.Transfer);
            transfer.Move(ref bSavedCachedExpressionData);
            if (bSavedCachedExpressionData.Value)
            {
                throw new NotImplementedException();
            }
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            base.Move(GlobalObjects.Transfer);
            transfer.Move(bSavedCachedExpressionData);
            if (bSavedCachedExpressionData.Value)
            {
                throw new NotImplementedException();
            }
        }
    }
}
