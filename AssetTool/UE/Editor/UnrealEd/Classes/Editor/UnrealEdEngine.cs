namespace AssetTool
{
    [JsonAsset("UnrealEdEngine")]
    public class UUnrealEdEngine : UEditorEngine
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}