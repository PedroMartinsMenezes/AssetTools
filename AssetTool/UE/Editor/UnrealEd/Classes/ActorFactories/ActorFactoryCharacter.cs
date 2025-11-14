namespace AssetTool
{
    [JsonAsset("ActorFactoryCharacter")]
    public class UActorFactoryCharacter : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}