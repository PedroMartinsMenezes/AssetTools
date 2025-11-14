namespace AssetTool
{
    [JsonAsset("GameSession")]
    public class AGameSession : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}