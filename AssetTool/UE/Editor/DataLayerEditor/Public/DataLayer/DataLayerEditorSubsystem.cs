namespace AssetTool
{
    [JsonAsset("DataLayerEditorSubsystem")]
    public class UDataLayerEditorSubsystem : UEditorSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}