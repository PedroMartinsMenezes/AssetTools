namespace AssetTool
{
    [JsonAsset("PCGSchedulingPolicyBase")]
    public class UPCGSchedulingPolicyBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}