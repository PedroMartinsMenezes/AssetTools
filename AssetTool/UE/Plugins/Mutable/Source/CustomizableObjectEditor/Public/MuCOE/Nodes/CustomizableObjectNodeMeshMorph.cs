namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMeshMorph")]
    public class UCustomizableObjectNodeMeshMorph : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}