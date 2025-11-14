namespace AssetTool
{
    [JsonAsset("ActorDescContainerInstance")]
    public class UActorDescContainerInstance : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}