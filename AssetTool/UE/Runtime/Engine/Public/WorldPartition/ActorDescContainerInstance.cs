namespace AssetTool
{
    [JsonAsset("ActorDescContainerInstance")]
    public class UActorDescContainerInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}