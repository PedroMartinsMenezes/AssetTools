namespace AssetTool
{
    [JsonAsset("ActorFactoryLevelSequence")]
    public class UActorFactoryLevelSequence : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}