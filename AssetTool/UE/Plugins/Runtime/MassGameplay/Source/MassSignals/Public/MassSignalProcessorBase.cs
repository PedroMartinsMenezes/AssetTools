namespace AssetTool
{
    [JsonAsset("MassSignalProcessorBase")]
    public class UMassSignalProcessorBase : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}