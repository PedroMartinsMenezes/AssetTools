namespace AssetTool
{
    [JsonAsset("DefaultTemplateProjectDefs")]
    public class UDefaultTemplateProjectDefs : UTemplateProjectDefs
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}