namespace AssetTool
{
    [JsonAsset("AsyncFallingMode")]
    public class UAsyncFallingMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}