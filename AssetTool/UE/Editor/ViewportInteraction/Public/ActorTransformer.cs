namespace AssetTool
{
    [JsonAsset("ActorTransformer")]
    public class UActorTransformer : UViewportTransformer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}