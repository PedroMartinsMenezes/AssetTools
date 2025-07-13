namespace AssetTool
{
    [JsonAsset("CustomizableObjectSettings")]
    public class UCustomizableObjectSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}