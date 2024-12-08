namespace AssetTool
{
    [JsonAsset("PlayerState")]
    public class APlayerState : AInfo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}