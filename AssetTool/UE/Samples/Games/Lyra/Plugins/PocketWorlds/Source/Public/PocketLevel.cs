namespace AssetTool
{
    [JsonAsset("PocketLevel")]
    public class UPocketLevel : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}