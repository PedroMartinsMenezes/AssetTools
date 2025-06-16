namespace AssetTool
{
    [JsonAsset("ActorFactoryCharacter")]
    public class UActorFactoryCharacter : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}