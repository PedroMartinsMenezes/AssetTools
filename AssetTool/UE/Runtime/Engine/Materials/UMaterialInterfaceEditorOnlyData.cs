namespace AssetTool
{
    [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
    public class UMaterialInterfaceEditorOnlyData : UObject
    {
        public const string TypeName = "MaterialInterfaceEditorOnlyData";

        public FBool bSavedCachedExpressionData;

        public new UMaterialInterfaceEditorOnlyData Move(Transfer transfer)
        {
            base.Move(GlobalObjects.Transfer);
            transfer.Move(ref bSavedCachedExpressionData);
            if (bSavedCachedExpressionData.Value)
            {
                throw new NotImplementedException();
            }
            return this;
        }
    }
}
