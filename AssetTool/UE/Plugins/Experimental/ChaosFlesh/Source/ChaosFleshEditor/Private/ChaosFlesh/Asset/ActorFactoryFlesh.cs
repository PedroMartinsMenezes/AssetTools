namespace AssetTool
{
    [JsonAsset("ActorFactoryFlesh")]
    public class UActorFactoryFlesh : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}