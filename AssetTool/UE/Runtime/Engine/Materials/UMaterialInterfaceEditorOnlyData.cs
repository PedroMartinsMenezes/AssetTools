namespace AssetTool
{
    [JsonAsset("MaterialInterfaceEditorOnlyData")]
    public class UMaterialInterfaceEditorOnlyData : UObject
    {
        public FBool bSavedCachedExpressionData;
        public UScriptStruct Struct;

        [Location("void UMaterialInterfaceEditorOnlyData::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref bSavedCachedExpressionData);
            if (bSavedCachedExpressionData.Value)
            {
                Struct ??= new();
                Struct.SerializeTaggedProperties(transfer);
            }
            return this;
        }
    }
}
