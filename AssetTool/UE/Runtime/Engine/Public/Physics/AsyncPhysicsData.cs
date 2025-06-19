namespace AssetTool
{
    [JsonAsset("AsyncPhysicsData")]
    public class UAsyncPhysicsData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}