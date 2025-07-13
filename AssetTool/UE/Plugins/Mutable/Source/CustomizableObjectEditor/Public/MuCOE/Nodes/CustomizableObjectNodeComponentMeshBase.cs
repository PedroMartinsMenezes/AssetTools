namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeComponentMeshBase")]
    public class UCustomizableObjectNodeComponentMeshBase : UCustomizableObjectNodeComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}