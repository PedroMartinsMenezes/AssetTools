namespace AssetTool
{
    [JsonAsset("VCamPlayerInput")]
    public class UVCamPlayerInput : UEnhancedPlayerInput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}