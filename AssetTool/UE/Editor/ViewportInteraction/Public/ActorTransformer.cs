namespace AssetTool
{
    [JsonAsset("ActorTransformer")]
    public class UActorTransformer : UViewportTransformer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}