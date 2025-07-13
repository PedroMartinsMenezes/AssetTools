namespace AssetTool
{
    [JsonAsset("VPGameMode")]
    public class AVPGameMode : AGameMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}