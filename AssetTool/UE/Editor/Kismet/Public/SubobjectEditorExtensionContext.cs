namespace AssetTool
{
    [JsonAsset("SubobjectEditorExtensionContext")]
    public class USubobjectEditorExtensionContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}