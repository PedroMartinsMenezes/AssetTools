namespace AssetTool
{
    [JsonAsset("UndoableResolveHandler")]
    public class UUndoableResolveHandler : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}