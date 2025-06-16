namespace AssetTool
{
    [JsonAsset("ActorFactoryPointLight")]
    public class UActorFactoryPointLight : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}