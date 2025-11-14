namespace AssetTool
{
    [JsonAsset("GameState")]
    public class AGameState : AGameStateBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}