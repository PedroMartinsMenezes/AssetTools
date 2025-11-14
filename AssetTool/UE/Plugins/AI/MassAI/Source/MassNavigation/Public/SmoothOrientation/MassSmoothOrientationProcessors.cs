namespace AssetTool
{
    [JsonAsset("MassSmoothOrientationProcessor")]
    public class UMassSmoothOrientationProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}