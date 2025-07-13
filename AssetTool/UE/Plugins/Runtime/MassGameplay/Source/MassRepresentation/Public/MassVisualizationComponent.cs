namespace AssetTool
{
    [JsonAsset("MassVisualizationComponent")]
    public class UMassVisualizationComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}