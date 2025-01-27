namespace AssetTool
{
    [JsonAsset("InterchangeBaseNode")]
    public class UInterchangeBaseNode : UObject
    {
        public FAttributeStorage RefAttributes;

        [Location("void UInterchangeBaseNode::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            transfer.Move(ref RefAttributes);
            return this;
        }
    }
}