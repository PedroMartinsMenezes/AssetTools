namespace AssetTool
{
    [JsonAsset("SmartObjectZoneAnnotations")]
    public class USmartObjectZoneAnnotations : UZoneGraphAnnotationComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}