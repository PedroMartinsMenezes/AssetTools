namespace AssetTool
{
    [JsonAsset("FlipbookEditorSettings")]
    public class UFlipbookEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}