namespace AssetTool
{
    [JsonAsset("DocumentationActor")]
    public class ADocumentationActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}