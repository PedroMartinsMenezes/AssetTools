namespace AssetTool
{
    [JsonAsset("InputVCamSubsystem")]
    public class UInputVCamSubsystem : UVCamSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}