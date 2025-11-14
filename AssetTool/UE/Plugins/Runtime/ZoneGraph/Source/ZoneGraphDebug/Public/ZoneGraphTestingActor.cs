namespace AssetTool
{
    [JsonAsset("ZoneLaneTest")]
    public class UZoneLaneTest : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ZoneGraphTestingComponent")]
    public class UZoneGraphTestingComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ZoneGraphTestingActor")]
    public class AZoneGraphTestingActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}