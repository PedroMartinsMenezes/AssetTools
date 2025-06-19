namespace AssetTool
{
    [JsonAsset("DefaultTemplateProjectDefs")]
    public class UDefaultTemplateProjectDefs : UTemplateProjectDefs
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}