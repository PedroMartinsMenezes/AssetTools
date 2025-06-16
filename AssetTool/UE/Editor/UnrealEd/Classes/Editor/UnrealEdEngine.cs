namespace AssetTool
{
    [JsonAsset("UnrealEdEngine")]
    public class UUnrealEdEngine : UEditorEngine
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}