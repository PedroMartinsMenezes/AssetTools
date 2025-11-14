namespace AssetTool
{
    [JsonAsset("WorldTileDetails")]
    public class UWorldTileDetails : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}