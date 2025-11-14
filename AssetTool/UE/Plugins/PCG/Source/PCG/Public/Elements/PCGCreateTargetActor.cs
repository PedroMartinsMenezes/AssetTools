namespace AssetTool
{
    [JsonAsset("PCGCreateTargetActor")]
    public class UPCGCreateTargetActor : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}