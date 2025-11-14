namespace AssetTool
{
    [JsonAsset("InputVCamSubsystem")]
    public class UInputVCamSubsystem : UVCamSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}