namespace AssetTool
{
    [JsonAsset("EditorConfigTestObject")]
    public class UEditorConfigTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}