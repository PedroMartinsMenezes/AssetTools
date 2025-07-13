namespace AssetTool
{
    [JsonAsset("MassDebugVisualizationComponent")]
    public class UMassDebugVisualizationComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}