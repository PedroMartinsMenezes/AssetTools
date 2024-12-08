namespace AssetTool
{
    [JsonAsset("GameStateBase")]
    public class AGameStateBase : AInfo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}