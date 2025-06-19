namespace AssetTool
{
    [JsonAsset("AvaTransitionStateExportData")]
    public class UAvaTransitionStateExportData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}