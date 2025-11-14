namespace AssetTool
{
    [JsonAsset("OutlinerConfig")]
    public class UOutlinerConfig : UEditorConfigBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}