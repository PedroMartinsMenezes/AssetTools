namespace AssetTool
{
    [JsonAsset("LandscapeMeshProxyActor")]
    public class ALandscapeMeshProxyActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}