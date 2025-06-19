namespace AssetTool
{
    [JsonAsset("PCGCreateTargetActor")]
    public class UPCGCreateTargetActor : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}