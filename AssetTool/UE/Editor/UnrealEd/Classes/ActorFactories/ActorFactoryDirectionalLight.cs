namespace AssetTool
{
    [JsonAsset("ActorFactoryDirectionalLight")]
    public class UActorFactoryDirectionalLight : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}