namespace AssetTool
{
    [JsonAsset("UnrealEdEngine")]
    public class UUnrealEdEngine : UEditorEngine
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}