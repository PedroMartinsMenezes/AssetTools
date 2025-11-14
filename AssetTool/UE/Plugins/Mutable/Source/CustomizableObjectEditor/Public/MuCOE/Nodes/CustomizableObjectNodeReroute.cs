namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeReroute")]
    public class UCustomizableObjectNodeReroute : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}