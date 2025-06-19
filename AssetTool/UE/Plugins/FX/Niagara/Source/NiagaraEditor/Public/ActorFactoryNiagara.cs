namespace AssetTool
{
    [JsonAsset("ActorFactoryNiagara")]
    public class UActorFactoryNiagara : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}