namespace AssetTool
{
    [JsonAsset("ZoneGraphAnnotationTest")]
    public class UZoneGraphAnnotationTest : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ZoneGraphAnnotationTestingComponent")]
    public class UZoneGraphAnnotationTestingComponent : UDebugDrawComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ZoneGraphAnnotationTestingActor")]
    public class AZoneGraphAnnotationTestingActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}