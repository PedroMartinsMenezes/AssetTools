namespace AssetTool
{
    [JsonAsset("MassLookAtProcessor")]
    public class UMassLookAtProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}