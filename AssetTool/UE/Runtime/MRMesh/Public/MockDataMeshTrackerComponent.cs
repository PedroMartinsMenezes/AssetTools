namespace AssetTool
{
    [JsonAsset("MockDataMeshTrackerComponent")]
    public class UMockDataMeshTrackerComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}