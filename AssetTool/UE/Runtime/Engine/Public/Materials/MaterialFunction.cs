namespace AssetTool
{
    [JsonAsset("MaterialFunctionEditorOnlyData")]
    public class UMaterialFunctionEditorOnlyData : UMaterialFunctionInterfaceEditorOnlyData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunction")]
    public class UMaterialFunction : UMaterialFunctionInterface
    {
        public UMaterialFunction()
        {
            ArrayMovers.Add("FunctionExpressions", (transfer, value) => value.ToObject<TInt32>(transfer).Move(transfer));
            ArrayMovers.Add("FunctionEditorComments", (transfer, value) => value.ToObject<TInt32>(transfer).Move(transfer));
            ArrayMovers.Add("LibraryCategories", (transfer, value) => value.ToObject<FString>(transfer).Move(transfer));
        }

        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}