namespace AssetTool
{
    [JsonAsset("InstancedActorsVisualizationProcessor")]
    public class UInstancedActorsVisualizationProcessor : UMassVisualizationProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}