namespace AssetTool
{
    [JsonAsset("CustomizableSystemImageProvider")]
    public class UCustomizableSystemImageProvider : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectSystem")]
    public class UCustomizableObjectSystem : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}