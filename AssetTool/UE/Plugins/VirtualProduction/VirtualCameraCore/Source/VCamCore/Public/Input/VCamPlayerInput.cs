namespace AssetTool
{
    [JsonAsset("VCamPlayerInput")]
    public class UVCamPlayerInput : UEnhancedPlayerInput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}