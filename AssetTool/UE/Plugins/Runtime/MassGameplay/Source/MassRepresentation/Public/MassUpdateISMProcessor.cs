namespace AssetTool
{
    [JsonAsset("MassUpdateISMProcessor")]
    public class UMassUpdateISMProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}