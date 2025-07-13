namespace AssetTool
{
    [JsonAsset("WeldMeshEdgesToolBuilder")]
    public class UWeldMeshEdgesToolBuilder : USingleTargetWithSelectionToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WeldMeshEdgesToolProperties")]
    public class UWeldMeshEdgesToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WeldMeshEdgesOperatorFactory")]
    public class UWeldMeshEdgesOperatorFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WeldMeshEdgesTool")]
    public class UWeldMeshEdgesTool : USingleTargetWithSelectionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}