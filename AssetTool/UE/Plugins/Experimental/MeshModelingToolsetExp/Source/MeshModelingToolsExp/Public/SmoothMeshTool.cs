namespace AssetTool
{
    [JsonAsset("SmoothMeshToolProperties")]
    public class USmoothMeshToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IterativeSmoothProperties")]
    public class UIterativeSmoothProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DiffusionSmoothProperties")]
    public class UDiffusionSmoothProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ImplicitSmoothProperties")]
    public class UImplicitSmoothProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmoothWeightMapSetProperties")]
    public class USmoothWeightMapSetProperties : UWeightMapSetProperties
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmoothMeshTool")]
    public class USmoothMeshTool : UBaseMeshProcessingTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmoothMeshToolBuilder")]
    public class USmoothMeshToolBuilder : UBaseMeshProcessingToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}