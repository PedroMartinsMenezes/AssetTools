namespace AssetTool
{
    [JsonAsset("LandscapeGizmoActiveActor")]
    public class ALandscapeGizmoActiveActor : AActor
    {
        public ALandscapeGizmoActiveActor()
        {
            ArrayMovers.Add("SampledHeight", (transfer, value) => value.ToObject<FVector>(transfer).Move(transfer));
        }

        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}