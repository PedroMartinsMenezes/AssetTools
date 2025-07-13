namespace AssetTool
{
    [JsonAsset("SequencerTimeChangeUndoRedoProxy")]
    public class USequencerTimeChangeUndoRedoProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}