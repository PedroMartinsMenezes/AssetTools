namespace AssetTool
{
    [JsonAsset("DocumentationSettings")]
    public class UDocumentationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}