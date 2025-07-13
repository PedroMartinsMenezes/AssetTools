namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeStaticMesh")]
    public class UCustomizableObjectNodeStaticMesh : UCustomizableObjectNodeMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}