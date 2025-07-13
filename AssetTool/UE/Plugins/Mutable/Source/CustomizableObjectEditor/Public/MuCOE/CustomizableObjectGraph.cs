namespace AssetTool
{
    [JsonAsset("CustomizableObjectGraph")]
    public class UCustomizableObjectGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}