namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMeshVariation")]
    public class UCustomizableObjectNodeMeshVariation : UCustomizableObjectNodeVariation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}