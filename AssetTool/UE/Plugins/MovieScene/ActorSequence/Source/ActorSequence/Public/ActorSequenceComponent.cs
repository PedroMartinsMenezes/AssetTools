namespace AssetTool
{
    [JsonAsset("ActorSequenceComponent")]
    public class UActorSequenceComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}