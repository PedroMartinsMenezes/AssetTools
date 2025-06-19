namespace AssetTool
{
    [JsonAsset("GameStateBase")]
    public class AGameStateBase : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}