namespace AssetTool
{
    [JsonAsset("MaterialGraph")]
    public class UMaterialGraph : UEdGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}