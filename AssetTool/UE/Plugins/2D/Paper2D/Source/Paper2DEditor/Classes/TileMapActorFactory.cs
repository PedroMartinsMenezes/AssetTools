namespace AssetTool
{
    [JsonAsset("TileMapActorFactory")]
    public class UTileMapActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}