namespace AssetTool
{
    [JsonAsset("GatherTextCommandletBase")]
    public class UGatherTextCommandletBase : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}