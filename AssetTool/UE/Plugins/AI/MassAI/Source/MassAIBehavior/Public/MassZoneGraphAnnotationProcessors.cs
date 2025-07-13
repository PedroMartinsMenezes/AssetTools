namespace AssetTool
{
    [JsonAsset("MassZoneGraphAnnotationTagsInitializer")]
    public class UMassZoneGraphAnnotationTagsInitializer : UMassObserverProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassZoneGraphAnnotationTagUpdateProcessor")]
    public class UMassZoneGraphAnnotationTagUpdateProcessor : UMassSignalProcessorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}