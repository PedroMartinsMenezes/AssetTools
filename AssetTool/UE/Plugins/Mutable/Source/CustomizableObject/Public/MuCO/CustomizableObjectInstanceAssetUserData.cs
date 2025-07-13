namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceUserData")]
    public class UCustomizableObjectInstanceUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}