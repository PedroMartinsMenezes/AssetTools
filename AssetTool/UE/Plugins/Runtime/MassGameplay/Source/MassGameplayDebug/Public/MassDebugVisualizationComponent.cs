namespace AssetTool
{
    [JsonAsset("MassDebugVisualizationComponent")]
    public class UMassDebugVisualizationComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}