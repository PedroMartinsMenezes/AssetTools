namespace AssetTool
{
    [JsonAsset("EditorConfigTestObject")]
    public class UEditorConfigTestObject : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}