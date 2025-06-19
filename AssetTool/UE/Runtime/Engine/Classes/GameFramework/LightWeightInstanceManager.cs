namespace AssetTool
{
    [JsonAsset("ActorInstanceHandleInterface")]
    public class UActorInstanceHandleInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LightWeightInstanceManager")]
    public class ALightWeightInstanceManager : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}