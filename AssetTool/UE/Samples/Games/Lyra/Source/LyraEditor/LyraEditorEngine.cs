namespace AssetTool
{
    [JsonAsset("LyraEditorEngine")]
    public class ULyraEditorEngine : UUnrealEdEngine
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}