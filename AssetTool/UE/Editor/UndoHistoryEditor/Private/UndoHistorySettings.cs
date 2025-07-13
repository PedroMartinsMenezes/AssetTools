namespace AssetTool
{
    [JsonAsset("UndoHistorySettings")]
    public class UUndoHistorySettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}