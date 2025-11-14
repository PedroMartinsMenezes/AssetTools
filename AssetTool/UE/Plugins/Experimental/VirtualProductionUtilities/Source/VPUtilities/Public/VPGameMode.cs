namespace AssetTool
{
    [JsonAsset("VPGameMode")]
    public class AVPGameMode : AGameMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}