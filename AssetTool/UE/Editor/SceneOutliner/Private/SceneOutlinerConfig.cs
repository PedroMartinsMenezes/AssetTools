namespace AssetTool
{
    [JsonAsset("OutlinerConfig")]
    public class UOutlinerConfig : UEditorConfigBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}