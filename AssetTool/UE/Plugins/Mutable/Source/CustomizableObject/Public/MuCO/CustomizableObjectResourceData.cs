namespace AssetTool
{
    [JsonAsset("CustomizableObjectResourceDataContainer")]
    public class UCustomizableObjectResourceDataContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}