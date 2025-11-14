namespace AssetTool
{
    [JsonAsset("MaterialFunctionInterfaceEditorOnlyData")]
    public class UMaterialFunctionInterfaceEditorOnlyData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunctionInterface")]
    public class UMaterialFunctionInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}