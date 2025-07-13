namespace AssetTool
{
    [JsonAsset("ColorCorrectRegion")]
    public class AColorCorrectRegion : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ColorCorrectionRegion")]
    public class AColorCorrectionRegion : AColorCorrectRegion
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ColorCorrectionInvisibleComponent")]
    public class UColorCorrectionInvisibleComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}