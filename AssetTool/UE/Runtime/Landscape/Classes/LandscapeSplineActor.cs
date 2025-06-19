namespace AssetTool
{
    [JsonAsset("LandscapeSplineActor")]
    public class ALandscapeSplineActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}