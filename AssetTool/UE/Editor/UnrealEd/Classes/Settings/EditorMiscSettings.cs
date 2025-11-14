namespace AssetTool
{
    [JsonAsset("EditorMiscSettings")]
    public class UEditorMiscSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}