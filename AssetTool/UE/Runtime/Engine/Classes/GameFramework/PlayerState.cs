namespace AssetTool
{
    [JsonAsset("PlayerState")]
    public class APlayerState : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}