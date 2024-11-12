namespace AssetTool
{
    [JsonAsset("ActorFactoryNiagara")]
    public class UActorFactoryNiagara : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}