namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstance")]
    public class UCustomizableObjectInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}