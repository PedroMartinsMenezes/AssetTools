namespace AssetTool
{
    [JsonAsset("AnimCurveCompressionCodec")]
    public class UAnimCurveCompressionCodec : UObject
    {
        public FGuid InstanceGuid;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref InstanceGuid);
            return this;
        }
    }
}