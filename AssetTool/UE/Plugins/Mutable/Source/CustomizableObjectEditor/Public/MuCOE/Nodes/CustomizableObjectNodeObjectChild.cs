namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeObjectChild")]
    public class UCustomizableObjectNodeObjectChild : UCustomizableObjectNodeObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}