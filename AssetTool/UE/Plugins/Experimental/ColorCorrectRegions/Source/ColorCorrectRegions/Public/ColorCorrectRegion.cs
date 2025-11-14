namespace AssetTool
{
    [JsonAsset("ColorCorrectRegion")]
    public class AColorCorrectRegion : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ColorCorrectionRegion")]
    public class AColorCorrectionRegion : AColorCorrectRegion
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ColorCorrectionInvisibleComponent")]
    public class UColorCorrectionInvisibleComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}