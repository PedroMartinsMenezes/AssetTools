namespace AssetTool
{
    [JsonAsset("AvaTransitionTreeEditorData")]
    public class UAvaTransitionTreeEditorData : UStateTreeEditorData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}