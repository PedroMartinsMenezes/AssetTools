namespace AssetTool
{
    [JsonAsset("PropertyBagSchema")]
    public class UPropertyBagSchema : UEdGraphSchema_K2
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}