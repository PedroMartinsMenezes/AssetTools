namespace AssetTool
{
    [JsonAsset("DocumentationSettings")]
    public class UDocumentationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}