namespace AssetTool
{
    [JsonAsset("EditorConfigTestObject")]
    public class UEditorConfigTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}