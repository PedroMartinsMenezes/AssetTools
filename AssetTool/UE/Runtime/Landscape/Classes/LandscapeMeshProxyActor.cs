namespace AssetTool
{
    [JsonAsset("LandscapeMeshProxyActor")]
    public class ALandscapeMeshProxyActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}