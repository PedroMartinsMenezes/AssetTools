namespace AssetTool
{
    [JsonAsset("AsyncFlyingMode")]
    public class UAsyncFlyingMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}