namespace AssetTool
{
    [JsonAsset("GameModeBase")]
    public class AGameModeBase : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}