namespace AssetTool
{
    [JsonAsset("ActorFactoryCharacter")]
    public class UActorFactoryCharacter : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}