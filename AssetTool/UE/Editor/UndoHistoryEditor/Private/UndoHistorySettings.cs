namespace AssetTool
{
    [JsonAsset("UndoHistorySettings")]
    public class UUndoHistorySettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}