namespace AssetTool
{
    [JsonAsset("ActorFactorySkyLight")]
    public class UActorFactorySkyLight : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}