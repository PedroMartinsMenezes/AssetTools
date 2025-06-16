namespace AssetTool
{
    [JsonAsset("PCGCreateTargetActor")]
    public class UPCGCreateTargetActor : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}