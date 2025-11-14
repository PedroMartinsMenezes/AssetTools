namespace AssetTool
{
    [JsonAsset("StateTreeEditorContext")]
    public class UStateTreeEditorContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}