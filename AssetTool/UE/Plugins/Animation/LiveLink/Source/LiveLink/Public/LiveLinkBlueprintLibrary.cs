namespace AssetTool
{
    [JsonAsset("LiveLinkBlueprintLibrary")]
    public class ULiveLinkBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}