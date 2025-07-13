namespace AssetTool
{
    [JsonAsset("NavCorridorTestingComponent")]
    public class UNavCorridorTestingComponent : UDebugDrawComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NavCorridorTestingActor")]
    public class ANavCorridorTestingActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}