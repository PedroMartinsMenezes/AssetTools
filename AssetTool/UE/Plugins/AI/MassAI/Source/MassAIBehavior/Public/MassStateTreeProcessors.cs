namespace AssetTool
{
    [JsonAsset("MassStateTreeFragmentDestructor")]
    public class UMassStateTreeFragmentDestructor : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassStateTreeActivationProcessor")]
    public class UMassStateTreeActivationProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassStateTreeProcessor")]
    public class UMassStateTreeProcessor : UMassSignalProcessorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}