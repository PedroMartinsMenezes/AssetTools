namespace AssetTool
{
    [JsonAsset("AIGraph")]
    public class UAIGraph : UEdGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}