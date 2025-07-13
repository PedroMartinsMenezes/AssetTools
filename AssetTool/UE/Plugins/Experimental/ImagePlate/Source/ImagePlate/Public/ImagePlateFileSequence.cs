namespace AssetTool
{
    [JsonAsset("ImagePlateSettings")]
    public class UImagePlateSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ImagePlateFileSequence")]
    public class UImagePlateFileSequence : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}