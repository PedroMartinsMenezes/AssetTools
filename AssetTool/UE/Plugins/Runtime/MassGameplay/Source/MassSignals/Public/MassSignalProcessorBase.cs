namespace AssetTool
{
    [JsonAsset("MassSignalProcessorBase")]
    public class UMassSignalProcessorBase : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}