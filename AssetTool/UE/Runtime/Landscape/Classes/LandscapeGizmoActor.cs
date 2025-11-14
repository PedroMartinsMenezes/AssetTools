namespace AssetTool
{
    [JsonAsset("LandscapeGizmoActor")]
    public class ALandscapeGizmoActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}