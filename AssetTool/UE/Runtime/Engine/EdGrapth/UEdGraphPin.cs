namespace AssetTool
{
    //Ver tambem bool FEdGraphPinType::Serialize(FArchive& Ar)
    [Location("UEdGraphPin::Serialize(FArchive& Ar)")]
    public class UEdGraphPin
    {
        public UInt32 OwningNode;
        public FGuid PinId;
        public FName PinName;
    }
}
