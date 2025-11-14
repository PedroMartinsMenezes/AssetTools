namespace AssetTool
{
    [JsonAsset("EditorSettings")]
    public class UEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}