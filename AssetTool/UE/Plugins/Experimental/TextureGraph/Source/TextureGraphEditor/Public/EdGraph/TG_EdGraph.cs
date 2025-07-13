namespace AssetTool
{
    [JsonAsset("TG_EdGraph")]
    public class UTG_EdGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}