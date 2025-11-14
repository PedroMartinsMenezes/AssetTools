namespace AssetTool
{
    [JsonAsset("SVGBakedActor")]
    public class ASVGBakedActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}