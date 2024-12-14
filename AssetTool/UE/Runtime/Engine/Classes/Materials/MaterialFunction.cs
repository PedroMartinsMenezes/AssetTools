namespace AssetTool
{
    [JsonAsset("MaterialFunctionEditorOnlyData")]
    public class UMaterialFunctionEditorOnlyData : UMaterialFunctionInterfaceEditorOnlyData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunction")]
    public class UMaterialFunction : UMaterialFunctionInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}