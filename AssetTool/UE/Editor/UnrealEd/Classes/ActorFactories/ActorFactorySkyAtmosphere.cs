namespace AssetTool
{
    [JsonAsset("ActorFactorySkyAtmosphere")]
    public class UActorFactorySkyAtmosphere : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}