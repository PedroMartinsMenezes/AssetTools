namespace AssetTool
{
    [JsonAsset("ActorFactoryPointLight")]
    public class UActorFactoryPointLight : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}