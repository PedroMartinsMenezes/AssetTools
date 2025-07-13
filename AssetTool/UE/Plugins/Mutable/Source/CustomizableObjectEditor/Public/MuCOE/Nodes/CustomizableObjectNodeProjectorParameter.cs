namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeProjectorParameter")]
    public class UCustomizableObjectNodeProjectorParameter : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}