namespace AssetTool
{
    [JsonAsset("DetailsConfig")]
    public class UDetailsConfig : UEditorConfigBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}