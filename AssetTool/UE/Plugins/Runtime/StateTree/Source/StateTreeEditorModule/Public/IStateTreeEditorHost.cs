namespace AssetTool
{
    [JsonAsset("StateTreeEditorContext")]
    public class UStateTreeEditorContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}