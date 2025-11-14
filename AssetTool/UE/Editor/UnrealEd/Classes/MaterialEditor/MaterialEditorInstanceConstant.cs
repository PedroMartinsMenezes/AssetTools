namespace AssetTool
{
    [JsonAsset("MaterialEditorParameters")]
    public class UMaterialEditorParameters : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialEditorInstanceConstant")]
    public class UMaterialEditorInstanceConstant : UMaterialEditorParameters
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}