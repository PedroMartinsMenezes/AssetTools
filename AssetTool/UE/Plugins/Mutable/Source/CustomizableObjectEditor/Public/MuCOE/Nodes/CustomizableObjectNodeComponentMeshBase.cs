namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeComponentMeshBase")]
    public class UCustomizableObjectNodeComponentMeshBase : UCustomizableObjectNodeComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}