namespace AssetTool
{
    [JsonAsset("TextRenderActor")]
    public class ATextRenderActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}