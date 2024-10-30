namespace AssetTool
{
    [JsonAsset("ActorElementCounterInterface")]
    public class UActorElementCounterInterface : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}