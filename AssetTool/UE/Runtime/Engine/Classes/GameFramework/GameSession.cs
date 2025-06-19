namespace AssetTool
{
    [JsonAsset("GameSession")]
    public class AGameSession : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}