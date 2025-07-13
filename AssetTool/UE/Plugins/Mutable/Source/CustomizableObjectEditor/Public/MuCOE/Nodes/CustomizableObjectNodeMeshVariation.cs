namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMeshVariation")]
    public class UCustomizableObjectNodeMeshVariation : UCustomizableObjectNodeVariation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}