namespace AssetTool
{
    [JsonAsset("ActorFactoryDatasmithScene")]
    public class UActorFactoryDatasmithScene : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}