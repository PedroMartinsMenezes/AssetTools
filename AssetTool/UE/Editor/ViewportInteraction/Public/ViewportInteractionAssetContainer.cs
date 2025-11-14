namespace AssetTool
{
    [JsonAsset("ViewportInteractionAssetContainer")]
    public class UViewportInteractionAssetContainer : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}