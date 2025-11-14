namespace AssetTool
{
    [JsonAsset("AvaTransitionStateExportData")]
    public class UAvaTransitionStateExportData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}