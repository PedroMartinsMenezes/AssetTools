namespace AssetTool
{
    [JsonAsset("MassLookAtProcessor")]
    public class UMassLookAtProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}