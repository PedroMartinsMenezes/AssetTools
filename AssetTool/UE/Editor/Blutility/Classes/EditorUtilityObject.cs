namespace AssetTool
{
    [JsonAsset("EditorUtilityObject")]
    public class UEditorUtilityObject : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}