namespace AssetTool
{
    [JsonAsset("ActorElementCounterInterface")]
    public class UActorElementCounterInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}