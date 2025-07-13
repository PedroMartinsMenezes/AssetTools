namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeReroute")]
    public class UCustomizableObjectNodeReroute : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}