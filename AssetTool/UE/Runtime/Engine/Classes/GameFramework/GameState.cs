namespace AssetTool
{
    [JsonAsset("GameState")]
    public class AGameState : AGameStateBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}