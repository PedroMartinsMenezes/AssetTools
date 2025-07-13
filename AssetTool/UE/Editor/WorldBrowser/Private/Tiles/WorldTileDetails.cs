namespace AssetTool
{
    [JsonAsset("WorldTileDetails")]
    public class UWorldTileDetails : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}