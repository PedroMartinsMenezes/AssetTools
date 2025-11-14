namespace AssetTool
{
    [JsonAsset("EditorConfigBase")]
    public class UEditorConfigBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}