namespace AssetTool
{
    [JsonAsset("EditMeshMaterialsToolBuilder")]
    public class UEditMeshMaterialsToolBuilder : UMeshSelectionToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshMaterialsToolProperties")]
    public class UEditMeshMaterialsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshMaterialsEditActions")]
    public class UEditMeshMaterialsEditActions : UMeshSelectionToolActionPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditMeshMaterialsTool")]
    public class UEditMeshMaterialsTool : UMeshSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}