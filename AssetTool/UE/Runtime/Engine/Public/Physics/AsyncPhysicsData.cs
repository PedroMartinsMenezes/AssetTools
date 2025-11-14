namespace AssetTool
{
    [JsonAsset("AsyncPhysicsData")]
    public class UAsyncPhysicsData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}