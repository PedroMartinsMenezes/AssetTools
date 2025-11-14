namespace AssetTool
{
    [JsonAsset("MassZoneGraphAnnotationTagsInitializer")]
    public class UMassZoneGraphAnnotationTagsInitializer : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassZoneGraphAnnotationTagUpdateProcessor")]
    public class UMassZoneGraphAnnotationTagUpdateProcessor : UMassSignalProcessorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}