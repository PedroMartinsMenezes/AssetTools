namespace AssetTool
{
    [JsonAsset("AssetEditorUISubsystem")]
    public class UAssetEditorUISubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}