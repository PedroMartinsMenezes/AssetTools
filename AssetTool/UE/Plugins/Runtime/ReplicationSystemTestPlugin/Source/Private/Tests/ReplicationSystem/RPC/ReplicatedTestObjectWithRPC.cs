namespace AssetTool
{
    [JsonAsset("TestReplicatedObjectWithRPC")]
    public class UTestReplicatedObjectWithRPC : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicatedObjectWithSingleRPC")]
    public class UTestReplicatedObjectWithSingleRPC : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}