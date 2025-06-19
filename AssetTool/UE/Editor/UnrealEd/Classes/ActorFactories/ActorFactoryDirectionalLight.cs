namespace AssetTool
{
    [JsonAsset("ActorFactoryDirectionalLight")]
    public class UActorFactoryDirectionalLight : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}