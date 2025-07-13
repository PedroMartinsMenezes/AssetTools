namespace AssetTool
{
    [JsonAsset("MassProcessor")]
    public class UMassProcessor : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCompositeProcessor")]
    public class UMassCompositeProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}