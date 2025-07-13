namespace AssetTool
{
    [JsonAsset("TemplateSequenceActor")]
    public class ATemplateSequenceActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}