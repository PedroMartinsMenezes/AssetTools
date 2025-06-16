namespace AssetTool
{
    [JsonAsset("ActorFactoryLevelSequence")]
    public class UActorFactoryLevelSequence : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}