namespace AssetTool
{
    [JsonAsset("ActorElementCounterInterface")]
    public class UActorElementCounterInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}