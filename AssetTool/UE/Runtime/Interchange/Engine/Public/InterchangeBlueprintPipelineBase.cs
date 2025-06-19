namespace AssetTool
{
    [JsonAsset("InterchangeBlueprintPipelineBase")]
    public class UInterchangeBlueprintPipelineBase : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}