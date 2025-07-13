namespace AssetTool
{
    [JsonAsset("MetasoundEditorSettings")]
    public class UMetasoundEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}