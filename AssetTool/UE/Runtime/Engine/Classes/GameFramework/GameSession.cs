namespace AssetTool
{
    [JsonAsset("GameSession")]
    public class AGameSession : AInfo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}