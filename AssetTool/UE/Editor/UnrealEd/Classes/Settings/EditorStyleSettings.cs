namespace AssetTool
{
    [JsonAsset("EditorStyleSettings")]
    public class UEditorStyleSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}