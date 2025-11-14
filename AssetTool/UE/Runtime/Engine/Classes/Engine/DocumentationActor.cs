namespace AssetTool
{
    [JsonAsset("DocumentationActor")]
    public class ADocumentationActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}