namespace AssetTool
{
    [JsonAsset("DefaultTemplateProjectDefs")]
    public class UDefaultTemplateProjectDefs : UTemplateProjectDefs
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}