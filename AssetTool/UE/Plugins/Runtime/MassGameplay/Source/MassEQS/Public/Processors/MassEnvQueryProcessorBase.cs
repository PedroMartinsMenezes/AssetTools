namespace AssetTool
{
    [JsonAsset("MassEnvQueryProcessorBase")]
    public class UMassEnvQueryProcessorBase : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}