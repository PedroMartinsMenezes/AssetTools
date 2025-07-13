namespace AssetTool
{
    [JsonAsset("ZoneGraphDisturbanceAnnotation")]
    public class UZoneGraphDisturbanceAnnotation : UZoneGraphAnnotationComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ZoneGraphDisturbanceAnnotationTest")]
    public class UZoneGraphDisturbanceAnnotationTest : UZoneGraphAnnotationTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}