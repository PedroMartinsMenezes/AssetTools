namespace AssetTool
{
    [JsonAsset("HairStrandsMutableExtension")]
    public class UHairStrandsMutableExtension : UCustomizableObjectExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}