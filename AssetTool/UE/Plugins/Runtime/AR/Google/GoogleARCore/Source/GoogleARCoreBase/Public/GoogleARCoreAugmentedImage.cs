namespace AssetTool
{
    [JsonAsset("GoogleARCoreAugmentedImage")]
    public class UGoogleARCoreAugmentedImage : UARTrackedImage
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}