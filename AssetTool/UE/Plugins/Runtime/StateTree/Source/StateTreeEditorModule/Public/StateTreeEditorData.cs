namespace AssetTool
{
    [JsonAsset("StateTreeEditorData")]
    public class UStateTreeEditorData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}