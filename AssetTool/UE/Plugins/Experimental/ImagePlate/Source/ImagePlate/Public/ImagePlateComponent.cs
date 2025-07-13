namespace AssetTool
{
    [JsonAsset("ImagePlateComponent")]
    public class UImagePlateComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}