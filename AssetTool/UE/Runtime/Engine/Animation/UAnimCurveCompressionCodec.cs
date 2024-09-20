namespace AssetTool
{
    [JsonAsset("AnimCurveCompressionCodec")]
    public class UAnimCurveCompressionCodec : UObject
    {
        public FGuid InstanceGuid;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref InstanceGuid);
            return this;
        }
    }
}