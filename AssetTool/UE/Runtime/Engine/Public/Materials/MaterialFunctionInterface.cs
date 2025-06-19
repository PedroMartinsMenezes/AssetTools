namespace AssetTool
{
    [JsonAsset("MaterialFunctionInterfaceEditorOnlyData")]
    public class UMaterialFunctionInterfaceEditorOnlyData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunctionInterface")]
    public class UMaterialFunctionInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}