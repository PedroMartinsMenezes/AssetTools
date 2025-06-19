namespace AssetTool
{
    [JsonAsset("GameState")]
    public class AGameState : AGameStateBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}