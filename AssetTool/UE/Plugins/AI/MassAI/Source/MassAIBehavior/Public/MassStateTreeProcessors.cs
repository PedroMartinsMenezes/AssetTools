namespace AssetTool
{
    [JsonAsset("MassStateTreeFragmentDestructor")]
    public class UMassStateTreeFragmentDestructor : UMassObserverProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassStateTreeActivationProcessor")]
    public class UMassStateTreeActivationProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassStateTreeProcessor")]
    public class UMassStateTreeProcessor : UMassSignalProcessorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}