namespace AssetTool
{
    [JsonAsset("VCamPlayerInput")]
    public class UVCamPlayerInput : UEnhancedPlayerInput
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}