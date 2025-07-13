namespace AssetTool
{
    [JsonAsset("ImagePlate")]
    public class AImagePlate : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}