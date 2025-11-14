namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeEditMaterialPinEditImageData")]
    public class UCustomizableObjectNodeEditMaterialPinEditImageData : UCustomizableObjectNodePinData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeModifierEditMeshSection")]
    public class UCustomizableObjectNodeModifierEditMeshSection : UCustomizableObjectNodeModifierEditLayoutBlocks
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}