namespace AssetTool
{
    [JsonAsset("MaterialEditorOptions")]
    public class UMaterialEditorOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}