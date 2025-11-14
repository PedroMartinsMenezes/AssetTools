namespace AssetTool
{
    [JsonAsset("AsyncFlyingMode")]
    public class UAsyncFlyingMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}