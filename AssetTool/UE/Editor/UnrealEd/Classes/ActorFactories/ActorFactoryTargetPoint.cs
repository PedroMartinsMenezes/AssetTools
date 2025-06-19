namespace AssetTool
{
    [JsonAsset("ActorFactoryTargetPoint")]
    public class UActorFactoryTargetPoint : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}