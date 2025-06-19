namespace AssetTool
{
    [JsonAsset("StateTreeEditorData")]
    public class UStateTreeEditorData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}