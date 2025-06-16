namespace AssetTool
{
    [JsonAsset("ActorFactorySkyAtmosphere")]
    public class UActorFactorySkyAtmosphere : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}