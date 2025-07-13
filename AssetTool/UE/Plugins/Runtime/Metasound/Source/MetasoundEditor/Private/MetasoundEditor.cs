namespace AssetTool
{
    [JsonAsset("MetasoundEditorViewBase")]
    public class UMetasoundEditorViewBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundInterfacesView")]
    public class UMetasoundInterfacesView : UMetasoundEditorViewBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetasoundPagesView")]
    public class UMetasoundPagesView : UMetasoundEditorViewBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}