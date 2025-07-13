namespace AssetTool
{
    [JsonAsset("GoogleARCoreAugmentedImage")]
    public class UGoogleARCoreAugmentedImage : UARTrackedImage
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}