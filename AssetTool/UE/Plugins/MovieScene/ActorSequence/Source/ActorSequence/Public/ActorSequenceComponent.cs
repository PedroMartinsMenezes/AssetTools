namespace AssetTool
{
    [JsonAsset("ActorSequenceComponent")]
    public class UActorSequenceComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}