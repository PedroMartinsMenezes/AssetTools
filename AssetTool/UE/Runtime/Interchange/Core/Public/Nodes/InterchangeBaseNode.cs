namespace AssetTool
{
    [JsonAsset("InterchangeBaseNode")]
    public class UInterchangeBaseNode : UObject
    {
        public FAttributeStorage RefAttributes;

        [Location("void UInterchangeBaseNode::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref RefAttributes);
            return this;
        }
    }
}