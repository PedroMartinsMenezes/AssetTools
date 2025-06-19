namespace AssetTool
{
    [JsonAsset("BrowseToAssetOverrideSubsystem")]
    public class UBrowseToAssetOverrideSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}