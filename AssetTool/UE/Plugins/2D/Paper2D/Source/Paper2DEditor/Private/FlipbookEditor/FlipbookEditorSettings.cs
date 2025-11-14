namespace AssetTool
{
    [JsonAsset("FlipbookEditorSettings")]
    public class UFlipbookEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}