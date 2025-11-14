namespace AssetTool
{
    [JsonAsset("EditorTutorialSettings")]
    public class UEditorTutorialSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}