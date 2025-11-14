namespace AssetTool
{
    [JsonAsset("UndoableResolveHandler")]
    public class UUndoableResolveHandler : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}