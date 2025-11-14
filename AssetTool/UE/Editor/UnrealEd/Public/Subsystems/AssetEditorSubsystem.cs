namespace AssetTool
{
    [JsonAsset("AssetEditorSubsystem")]
    public class UAssetEditorSubsystem : UEditorSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}