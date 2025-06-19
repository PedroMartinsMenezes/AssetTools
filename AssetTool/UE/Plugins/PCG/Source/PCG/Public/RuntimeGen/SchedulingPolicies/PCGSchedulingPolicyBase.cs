namespace AssetTool
{
    [JsonAsset("PCGSchedulingPolicyBase")]
    public class UPCGSchedulingPolicyBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}