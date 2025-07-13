namespace AssetTool
{
    [JsonAsset("HarvestInstancesToolBuilder")]
    public class UHarvestInstancesToolBuilder : UMultiSelectionMeshEditingToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarvestInstancesToolSettings")]
    public class UHarvestInstancesToolSettings : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarvestInstancesTool_OutputSettings")]
    public class UHarvestInstancesTool_OutputSettings : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarvestInstancesTool")]
    public class UHarvestInstancesTool : UMultiSelectionMeshEditingTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}