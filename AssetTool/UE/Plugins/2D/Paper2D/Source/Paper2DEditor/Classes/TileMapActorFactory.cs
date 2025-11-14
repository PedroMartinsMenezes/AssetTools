namespace AssetTool
{
    [JsonAsset("TileMapActorFactory")]
    public class UTileMapActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}