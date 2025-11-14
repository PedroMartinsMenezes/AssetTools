namespace AssetTool
{
    [JsonAsset("MassSmartObjectCandidatesFinderProcessor")]
    public class UMassSmartObjectCandidatesFinderProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassSmartObjectTimedBehaviorProcessor")]
    public class UMassSmartObjectTimedBehaviorProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassSmartObjectUserFragmentDeinitializer")]
    public class UMassSmartObjectUserFragmentDeinitializer : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}