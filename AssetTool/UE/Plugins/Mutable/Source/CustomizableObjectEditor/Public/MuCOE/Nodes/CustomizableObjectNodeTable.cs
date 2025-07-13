namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeTableObjectPinData")]
    public class UCustomizableObjectNodeTableObjectPinData : UCustomizableObjectNodePinData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeTableImagePinData")]
    public class UCustomizableObjectNodeTableImagePinData : UCustomizableObjectNodeTableObjectPinData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeTableMeshPinData")]
    public class UCustomizableObjectNodeTableMeshPinData : UCustomizableObjectNodeTableObjectPinData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeTableRemapPins")]
    public class UCustomizableObjectNodeTableRemapPins : UCustomizableObjectNodeRemapPinsByName
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectNodeTable")]
    public class UCustomizableObjectNodeTable : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}