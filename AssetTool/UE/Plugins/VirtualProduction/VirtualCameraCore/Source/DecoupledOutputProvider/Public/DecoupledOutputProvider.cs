namespace AssetTool
{
    [JsonAsset("DecoupledOutputProvider")]
    public class UDecoupledOutputProvider : UVCamOutputProviderBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}