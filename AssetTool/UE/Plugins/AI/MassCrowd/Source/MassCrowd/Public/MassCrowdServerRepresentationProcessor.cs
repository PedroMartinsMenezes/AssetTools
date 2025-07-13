namespace AssetTool
{
    [JsonAsset("MassCrowdServerRepresentationProcessor")]
    public class UMassCrowdServerRepresentationProcessor : UMassRepresentationProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}