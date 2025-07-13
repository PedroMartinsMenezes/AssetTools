namespace AssetTool
{
    [JsonAsset("AttributeEditorToolBuilder")]
    public class UAttributeEditorToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AttributeEditorAttribProperties")]
    public class UAttributeEditorAttribProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AttributeEditorActionPropertySet")]
    public class UAttributeEditorActionPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AttributeEditorNormalsActions")]
    public class UAttributeEditorNormalsActions : UAttributeEditorActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AttributeEditorUVActions")]
    public class UAttributeEditorUVActions : UAttributeEditorActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AttributeEditorLightmapUVActions")]
    public class UAttributeEditorLightmapUVActions : UAttributeEditorActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AttributeEditorNewAttributeActions")]
    public class UAttributeEditorNewAttributeActions : UAttributeEditorActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AttributeEditorModifyAttributeActions")]
    public class UAttributeEditorModifyAttributeActions : UAttributeEditorActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AttributeEditorCopyAttributeActions")]
    public class UAttributeEditorCopyAttributeActions : UAttributeEditorActionPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AttributeEditorTool")]
    public class UAttributeEditorTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}