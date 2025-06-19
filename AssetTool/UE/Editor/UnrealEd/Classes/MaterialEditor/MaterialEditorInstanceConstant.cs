namespace AssetTool
{
    [JsonAsset("MaterialEditorParameters")]
    public class UMaterialEditorParameters : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialEditorInstanceConstant")]
    public class UMaterialEditorInstanceConstant : UMaterialEditorParameters
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}