namespace AssetTool
{
    [JsonAsset("OffsetMeshToolProperties")]
    public class UOffsetMeshToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OffsetWeightMapSetProperties")]
    public class UOffsetWeightMapSetProperties : UWeightMapSetProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IterativeOffsetProperties")]
    public class UIterativeOffsetProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ImplicitOffsetProperties")]
    public class UImplicitOffsetProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OffsetMeshTool")]
    public class UOffsetMeshTool : UBaseMeshProcessingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OffsetMeshToolBuilder")]
    public class UOffsetMeshToolBuilder : UBaseMeshProcessingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}