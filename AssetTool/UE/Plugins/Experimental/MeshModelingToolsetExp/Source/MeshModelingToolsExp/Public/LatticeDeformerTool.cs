namespace AssetTool
{
    [JsonAsset("LatticeDeformerToolBuilder")]
    public class ULatticeDeformerToolBuilder : UMultiTargetWithSelectionToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LatticeDeformerToolProperties")]
    public class ULatticeDeformerToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LatticeDeformerOperatorFactory")]
    public class ULatticeDeformerOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LatticeDeformerTool")]
    public class ULatticeDeformerTool : UMultiTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}