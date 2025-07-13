namespace AssetTool
{
    [JsonAsset("EditorGizmoStateTarget")]
    public class UEditorGizmoStateTarget : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}