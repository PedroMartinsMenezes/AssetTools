namespace AssetTool
{
    [JsonAsset("ChaosDebugDrawComponent")]
    public class UChaosDebugDrawComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}