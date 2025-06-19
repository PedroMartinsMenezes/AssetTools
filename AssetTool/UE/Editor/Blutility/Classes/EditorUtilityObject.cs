namespace AssetTool
{
    [JsonAsset("EditorUtilityObject")]
    public class UEditorUtilityObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}