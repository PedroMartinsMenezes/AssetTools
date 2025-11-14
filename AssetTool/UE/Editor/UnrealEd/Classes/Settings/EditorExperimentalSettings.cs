namespace AssetTool
{
    [JsonAsset("EditorExperimentalSettings")]
    public class UEditorExperimentalSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}