namespace AssetTool
{
    [JsonAsset("ConcertAssetContainer")]
    public class UConcertAssetContainer : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}