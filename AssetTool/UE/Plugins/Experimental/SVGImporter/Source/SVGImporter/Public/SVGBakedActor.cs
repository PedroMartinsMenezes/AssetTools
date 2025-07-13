namespace AssetTool
{
    [JsonAsset("SVGBakedActor")]
    public class ASVGBakedActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}