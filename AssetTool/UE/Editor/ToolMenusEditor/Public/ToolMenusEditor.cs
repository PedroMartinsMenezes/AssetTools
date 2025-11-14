namespace AssetTool
{
    [JsonAsset("ToolMenuEditorDialogObject")]
    public class UToolMenuEditorDialogObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToolMenuEditorDialogMenu")]
    public class UToolMenuEditorDialogMenu : UToolMenuEditorDialogObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToolMenuEditorDialogBlock")]
    public class UToolMenuEditorDialogBlock : UToolMenuEditorDialogObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToolMenuEditorDialogSection")]
    public class UToolMenuEditorDialogSection : UToolMenuEditorDialogBlock
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ToolMenuEditorDialogEntry")]
    public class UToolMenuEditorDialogEntry : UToolMenuEditorDialogBlock
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}