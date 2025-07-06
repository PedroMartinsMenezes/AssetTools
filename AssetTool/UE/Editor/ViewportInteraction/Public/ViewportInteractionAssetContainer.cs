namespace AssetTool
{
    [JsonAsset("ViewportInteractionAssetContainer")]
    public class UViewportInteractionAssetContainer : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}