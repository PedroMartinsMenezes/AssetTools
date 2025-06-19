namespace AssetTool
{
    [JsonAsset("AvaTransitionTreeEditorData")]
    public class UAvaTransitionTreeEditorData : UStateTreeEditorData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}