namespace AssetTool
{
    [JsonAsset("EditorGizmoStateTarget")]
    public class UEditorGizmoStateTarget : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}