namespace AssetTool
{
    [JsonAsset("InterchangeBlueprintPipelineBase")]
    public class UInterchangeBlueprintPipelineBase : UBlueprint
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}