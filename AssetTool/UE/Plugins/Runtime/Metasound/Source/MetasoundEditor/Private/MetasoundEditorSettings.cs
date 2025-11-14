namespace AssetTool
{
    [JsonAsset("MetasoundEditorSettings")]
    public class UMetasoundEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}