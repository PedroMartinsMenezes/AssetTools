namespace AssetTool
{
    [JsonAsset("MaterialGraph")]
    public class UMaterialGraph : UEdGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}