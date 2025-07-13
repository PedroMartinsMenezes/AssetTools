namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeEditMaterialPinEditImageData")]
    public class UCustomizableObjectNodeEditMaterialPinEditImageData : UCustomizableObjectNodePinData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeModifierEditMeshSection")]
    public class UCustomizableObjectNodeModifierEditMeshSection : UCustomizableObjectNodeModifierEditLayoutBlocks
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}