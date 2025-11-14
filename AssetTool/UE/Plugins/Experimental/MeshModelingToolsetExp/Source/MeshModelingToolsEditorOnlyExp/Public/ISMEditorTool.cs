namespace AssetTool
{
    [JsonAsset("ISMEditorToolBuilder")]
    public class UISMEditorToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ISMEditorToolProperties")]
    public class UISMEditorToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ISMEditorToolActionPropertySetBase")]
    public class UISMEditorToolActionPropertySetBase : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ISMEditorToolActionPropertySet")]
    public class UISMEditorToolActionPropertySet : UISMEditorToolActionPropertySetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ISMEditorToolReplacePropertySet")]
    public class UISMEditorToolReplacePropertySet : UISMEditorToolActionPropertySetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ISMEditorTool")]
    public class UISMEditorTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}