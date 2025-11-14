namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeStaticMesh")]
    public class UCustomizableObjectNodeStaticMesh : UCustomizableObjectNodeMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}