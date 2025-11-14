namespace AssetTool
{
    [JsonAsset("EditorGizmoRegistryCategoryEntry")]
    public class UEditorGizmoRegistryCategoryEntry : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorGizmoRegistryCategoryEntry_ConditionalSelection")]
    public class UEditorGizmoRegistryCategoryEntry_ConditionalSelection : UEditorGizmoRegistryCategoryEntry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorGizmoRegistryCategoryEntry_Primary")]
    public class UEditorGizmoRegistryCategoryEntry_Primary : UEditorGizmoRegistryCategoryEntry_ConditionalSelection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorGizmoRegistryCategoryEntry_Accessory")]
    public class UEditorGizmoRegistryCategoryEntry_Accessory : UEditorGizmoRegistryCategoryEntry_ConditionalSelection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorInteractiveGizmoRegistry")]
    public class UEditorInteractiveGizmoRegistry : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}