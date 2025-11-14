namespace AssetTool
{
    [JsonAsset("ActorFactoryTargetPoint")]
    public class UActorFactoryTargetPoint : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}