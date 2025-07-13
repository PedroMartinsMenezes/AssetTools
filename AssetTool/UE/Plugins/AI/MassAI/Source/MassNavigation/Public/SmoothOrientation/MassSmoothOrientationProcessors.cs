namespace AssetTool
{
    [JsonAsset("MassSmoothOrientationProcessor")]
    public class UMassSmoothOrientationProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}