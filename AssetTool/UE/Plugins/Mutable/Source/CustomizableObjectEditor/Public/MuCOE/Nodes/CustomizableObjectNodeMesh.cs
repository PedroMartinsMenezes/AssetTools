namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMesh")]
    public class UCustomizableObjectNodeMesh : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}