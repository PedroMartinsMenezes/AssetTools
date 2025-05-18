namespace AssetTool
{
    [JsonAsset("AvaTransitionTreeEditorData")]
    public class UAvaTransitionTreeEditorData : UStateTreeEditorData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}