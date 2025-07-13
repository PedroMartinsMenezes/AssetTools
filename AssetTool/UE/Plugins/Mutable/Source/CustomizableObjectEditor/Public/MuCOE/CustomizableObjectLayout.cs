namespace AssetTool
{
    [JsonAsset("CustomizableObjectLayout")]
    public class UCustomizableObjectLayout : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}