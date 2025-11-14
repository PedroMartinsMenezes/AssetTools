namespace AssetTool
{
    [JsonAsset("SmartObjectZoneAnnotations")]
    public class USmartObjectZoneAnnotations : UZoneGraphAnnotationComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}