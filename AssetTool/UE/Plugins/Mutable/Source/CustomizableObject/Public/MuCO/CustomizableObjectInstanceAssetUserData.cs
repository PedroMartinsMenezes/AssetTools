namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceUserData")]
    public class UCustomizableObjectInstanceUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}