namespace AssetTool
{
    [JsonAsset("ZoneGraphDisturbanceAnnotation")]
    public class UZoneGraphDisturbanceAnnotation : UZoneGraphAnnotationComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ZoneGraphDisturbanceAnnotationTest")]
    public class UZoneGraphDisturbanceAnnotationTest : UZoneGraphAnnotationTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}