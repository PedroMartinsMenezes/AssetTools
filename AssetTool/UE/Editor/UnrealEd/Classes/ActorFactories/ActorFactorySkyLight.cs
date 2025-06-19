namespace AssetTool
{
    [JsonAsset("ActorFactorySkyLight")]
    public class UActorFactorySkyLight : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}