namespace AssetTool
{
    [JsonAsset("LandscapeGizmoActor")]
    public class ALandscapeGizmoActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}