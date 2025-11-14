namespace AssetTool
{
    [JsonAsset("ChaosDebugDrawComponent")]
    public class UChaosDebugDrawComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}