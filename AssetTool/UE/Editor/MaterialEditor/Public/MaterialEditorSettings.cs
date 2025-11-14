namespace AssetTool
{
    [JsonAsset("MaterialEditorSettings")]
    public class UMaterialEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}