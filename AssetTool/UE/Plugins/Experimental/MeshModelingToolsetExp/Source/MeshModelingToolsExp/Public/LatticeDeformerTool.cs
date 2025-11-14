namespace AssetTool
{
    [JsonAsset("LatticeDeformerToolBuilder")]
    public class ULatticeDeformerToolBuilder : UMultiTargetWithSelectionToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LatticeDeformerToolProperties")]
    public class ULatticeDeformerToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LatticeDeformerOperatorFactory")]
    public class ULatticeDeformerOperatorFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LatticeDeformerTool")]
    public class ULatticeDeformerTool : UMultiTargetWithSelectionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}