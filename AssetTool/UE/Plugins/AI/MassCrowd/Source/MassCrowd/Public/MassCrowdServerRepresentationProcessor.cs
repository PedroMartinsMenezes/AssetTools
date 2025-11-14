namespace AssetTool
{
    [JsonAsset("MassCrowdServerRepresentationProcessor")]
    public class UMassCrowdServerRepresentationProcessor : UMassRepresentationProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}