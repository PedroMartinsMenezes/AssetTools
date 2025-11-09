namespace AssetTool
{
    [JsonAsset("LandscapeGizmoActiveActor")]
    public class ALandscapeGizmoActiveActor : ALandscapeGizmoActor
    {
        public ALandscapeGizmoActiveActor()
        {
            ArrayMovers.Add("SampledHeight", (transfer, value) => value.ToObject<FVector>(transfer).Move(transfer));
        }

        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}