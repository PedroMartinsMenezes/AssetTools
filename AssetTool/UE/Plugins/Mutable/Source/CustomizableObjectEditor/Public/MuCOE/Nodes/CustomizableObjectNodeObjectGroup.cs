namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeObjectGroup")]
    public class UCustomizableObjectNodeObjectGroup : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}