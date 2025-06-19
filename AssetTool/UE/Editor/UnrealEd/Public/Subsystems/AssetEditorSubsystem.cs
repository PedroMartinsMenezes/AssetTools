namespace AssetTool
{
    [JsonAsset("AssetEditorSubsystem")]
    public class UAssetEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}