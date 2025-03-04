namespace AssetTool
{
    [JsonAsset("DecoupledOutputProvider")]
    public class UDecoupledOutputProvider : UVCamOutputProviderBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}