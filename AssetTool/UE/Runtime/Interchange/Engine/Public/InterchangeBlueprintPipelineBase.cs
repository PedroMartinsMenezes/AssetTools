namespace AssetTool
{
    [JsonAsset("InterchangeBlueprintPipelineBase")]
    public class UInterchangeBlueprintPipelineBase : UBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}