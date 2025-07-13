namespace AssetTool
{
    [JsonAsset("DataflowSimulationSceneDescription")]
    public class UDataflowSimulationSceneDescription : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}