namespace AssetTool
{
    [JsonAsset("PlayerState")]
    public class APlayerState : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}