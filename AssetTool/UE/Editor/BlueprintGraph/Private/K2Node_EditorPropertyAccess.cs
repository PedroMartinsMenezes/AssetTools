namespace AssetTool
{
    [JsonAsset("K2Node_EditorPropertyAccessBase")]
    public class UK2Node_EditorPropertyAccessBase : UK2Node_CallFunction
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("K2Node_GetEditorProperty")]
    public class UK2Node_GetEditorProperty : UK2Node_EditorPropertyAccessBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("K2Node_SetEditorProperty")]
    public class UK2Node_SetEditorProperty : UK2Node_EditorPropertyAccessBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}