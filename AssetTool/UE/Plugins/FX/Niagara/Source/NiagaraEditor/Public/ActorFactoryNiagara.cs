namespace AssetTool
{
    [JsonAsset("ActorFactoryNiagara")]
    public class UActorFactoryNiagara : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}