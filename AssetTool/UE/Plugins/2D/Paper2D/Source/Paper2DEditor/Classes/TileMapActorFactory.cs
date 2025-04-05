namespace AssetTool
{
    [JsonAsset("TileMapActorFactory")]
    public class UTileMapActorFactory : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}