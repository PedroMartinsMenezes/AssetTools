namespace AssetTool
{
    [JsonAsset("ActorFactoryPointLight")]
    public class UActorFactoryPointLight : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}