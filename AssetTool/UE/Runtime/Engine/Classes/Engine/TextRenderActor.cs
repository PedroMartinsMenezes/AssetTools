namespace AssetTool
{
    [JsonAsset("TextRenderActor")]
    public class ATextRenderActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}