namespace AssetTool
{
    [JsonAsset("LevelSequenceEditorSettings")]
    public class ULevelSequenceEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelSequenceWithShotsSettings")]
    public class ULevelSequenceWithShotsSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}