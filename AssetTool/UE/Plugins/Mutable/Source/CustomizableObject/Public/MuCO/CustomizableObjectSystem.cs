namespace AssetTool
{
    [JsonAsset("CustomizableSystemImageProvider")]
    public class UCustomizableSystemImageProvider : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectSystem")]
    public class UCustomizableObjectSystem : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}