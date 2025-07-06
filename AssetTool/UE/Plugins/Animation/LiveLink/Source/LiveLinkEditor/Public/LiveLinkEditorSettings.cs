namespace AssetTool
{
    [JsonAsset("LiveLinkEditorSettings")]
    public class ULiveLinkEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}