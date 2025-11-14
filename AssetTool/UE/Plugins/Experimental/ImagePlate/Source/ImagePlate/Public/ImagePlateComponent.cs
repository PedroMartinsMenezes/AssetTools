namespace AssetTool
{
    [JsonAsset("ImagePlateComponent")]
    public class UImagePlateComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}