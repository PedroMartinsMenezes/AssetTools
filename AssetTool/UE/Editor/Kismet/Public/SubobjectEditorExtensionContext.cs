namespace AssetTool
{
    [JsonAsset("SubobjectEditorExtensionContext")]
    public class USubobjectEditorExtensionContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}