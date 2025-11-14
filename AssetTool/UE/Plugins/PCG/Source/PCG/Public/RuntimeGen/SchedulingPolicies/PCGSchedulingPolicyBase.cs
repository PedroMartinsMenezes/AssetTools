namespace AssetTool
{
    [JsonAsset("PCGSchedulingPolicyBase")]
    public class UPCGSchedulingPolicyBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}