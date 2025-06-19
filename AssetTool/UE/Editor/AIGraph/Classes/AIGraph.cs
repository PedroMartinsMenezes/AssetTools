namespace AssetTool
{
    [JsonAsset("AIGraph")]
    public class UAIGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}