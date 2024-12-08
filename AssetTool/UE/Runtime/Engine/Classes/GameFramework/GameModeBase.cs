namespace AssetTool
{
    [JsonAsset("GameModeBase")]
    public class AGameModeBase : AInfo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}