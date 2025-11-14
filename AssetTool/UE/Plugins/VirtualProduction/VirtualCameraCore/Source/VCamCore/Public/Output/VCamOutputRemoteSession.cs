namespace AssetTool
{
    [JsonAsset("VCamOutputRemoteSession")]
    public class UVCamOutputRemoteSession : UVCamOutputProviderBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}