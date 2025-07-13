namespace AssetTool
{
    [JsonAsset("MassUpdateISMProcessor")]
    public class UMassUpdateISMProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}