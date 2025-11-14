namespace AssetTool
{
    [JsonAsset("GatherTextCommandletBase")]
    public class UGatherTextCommandletBase : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}