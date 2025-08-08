namespace AssetTool
{
    [JsonAsset("AsyncFallingMode")]
    public class UAsyncFallingMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}