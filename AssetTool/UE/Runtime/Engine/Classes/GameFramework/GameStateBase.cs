namespace AssetTool
{
    [JsonAsset("GameStateBase")]
    public class AGameStateBase : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}