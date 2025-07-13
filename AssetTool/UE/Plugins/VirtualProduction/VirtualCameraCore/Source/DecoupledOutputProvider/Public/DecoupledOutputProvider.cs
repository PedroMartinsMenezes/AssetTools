namespace AssetTool
{
    [JsonAsset("DecoupledOutputProvider")]
    public class UDecoupledOutputProvider : UVCamOutputProviderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}