namespace AssetTool
{
    [JsonAsset("EditorUtilityObject")]
    public class UEditorUtilityObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}