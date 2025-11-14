namespace AssetTool
{
    [JsonAsset("ActorFactoryLevelSequence")]
    public class UActorFactoryLevelSequence : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}