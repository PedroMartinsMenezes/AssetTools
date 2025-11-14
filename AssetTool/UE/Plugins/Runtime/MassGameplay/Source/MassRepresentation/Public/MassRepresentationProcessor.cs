namespace AssetTool
{
    [JsonAsset("MassRepresentationProcessor")]
    public class UMassRepresentationProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassVisualizationProcessor")]
    public class UMassVisualizationProcessor : UMassRepresentationProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassRepresentationFragmentDestructor")]
    public class UMassRepresentationFragmentDestructor : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}