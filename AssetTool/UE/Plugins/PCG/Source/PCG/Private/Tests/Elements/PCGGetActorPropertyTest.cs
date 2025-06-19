namespace AssetTool
{
    [JsonAsset("PCGDummyGetPropertyTest")]
    public class UPCGDummyGetPropertyTest : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGUnitTestDummyActor")]
    public class APCGUnitTestDummyActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGUnitTestDummyComponent")]
    public class UPCGUnitTestDummyComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}