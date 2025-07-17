namespace AssetTool
{
    [JsonAsset("LyraEditorEngine")]
    public class ULyraEditorEngine : UUnrealEdEngine
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}