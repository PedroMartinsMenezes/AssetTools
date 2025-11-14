namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMesh")]
    public class UCustomizableObjectNodeMesh : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}