namespace AssetTool
{
    [JsonAsset("TemplateSequenceActor")]
    public class ATemplateSequenceActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}