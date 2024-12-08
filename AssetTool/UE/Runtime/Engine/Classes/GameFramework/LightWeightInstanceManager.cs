namespace AssetTool
{
    [JsonAsset("ActorInstanceHandleInterface")]
    public class UActorInstanceHandleInterface : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LightWeightInstanceManager")]
    public class ALightWeightInstanceManager : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}