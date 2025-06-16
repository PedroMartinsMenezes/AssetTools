namespace AssetTool
{
    [JsonAsset("PCGDummyGetPropertyTest")]
    public class UPCGDummyGetPropertyTest : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGUnitTestDummyActor")]
    public class APCGUnitTestDummyActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGUnitTestDummyComponent")]
    public class UPCGUnitTestDummyComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}