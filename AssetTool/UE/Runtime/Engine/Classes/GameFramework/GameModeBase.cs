namespace AssetTool
{
    [JsonAsset("GameModeBase")]
    public class AGameModeBase : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}