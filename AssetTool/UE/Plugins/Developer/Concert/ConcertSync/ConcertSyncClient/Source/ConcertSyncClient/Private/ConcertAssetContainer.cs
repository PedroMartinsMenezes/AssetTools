namespace AssetTool
{
    [JsonAsset("ConcertAssetContainer")]
    public class UConcertAssetContainer : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}