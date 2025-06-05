namespace AssetTool
{
    [JsonAsset("DataprepGraph")]
    public class UDataprepGraph : UEdGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepGraphRecipeNode")]
    public class UDataprepGraphRecipeNode : UEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}