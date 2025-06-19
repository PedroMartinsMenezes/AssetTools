namespace AssetTool
{
    [JsonAsset("EditorExperimentalSettings")]
    public class UEditorExperimentalSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}