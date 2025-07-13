namespace AssetTool
{
    [JsonAsset("GameplayTagSearchFilter")]
    public class UGameplayTagSearchFilter : UContentBrowserFrontEndFilterExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}