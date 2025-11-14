namespace AssetTool
{
    [JsonAsset("AvaEditorContext")]
    public class UAvaEditorContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}