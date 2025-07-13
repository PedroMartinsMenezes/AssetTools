namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceBaker")]
    public class UCustomizableObjectInstanceBaker : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}