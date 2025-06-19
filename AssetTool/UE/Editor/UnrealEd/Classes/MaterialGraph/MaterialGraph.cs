namespace AssetTool
{
    [JsonAsset("MaterialGraph")]
    public class UMaterialGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}