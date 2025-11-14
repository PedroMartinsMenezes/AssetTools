namespace AssetTool
{
    [JsonAsset("AIGraph")]
    public class UAIGraph : UEdGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}