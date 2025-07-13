namespace AssetTool
{
    [JsonAsset("MassEnvQueryProcessorBase")]
    public class UMassEnvQueryProcessorBase : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}