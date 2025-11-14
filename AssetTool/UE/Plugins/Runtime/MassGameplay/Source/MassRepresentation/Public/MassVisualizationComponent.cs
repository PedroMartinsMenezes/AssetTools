namespace AssetTool
{
    [JsonAsset("MassVisualizationComponent")]
    public class UMassVisualizationComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}