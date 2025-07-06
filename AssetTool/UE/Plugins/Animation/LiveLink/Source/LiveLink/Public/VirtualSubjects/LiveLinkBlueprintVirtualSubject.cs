namespace AssetTool
{
    [JsonAsset("LiveLinkBlueprintVirtualSubject")]
    public class ULiveLinkBlueprintVirtualSubject : ULiveLinkVirtualSubject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}