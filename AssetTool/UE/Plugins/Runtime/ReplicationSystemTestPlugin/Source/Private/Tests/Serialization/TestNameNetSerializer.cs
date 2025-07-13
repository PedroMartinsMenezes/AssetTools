namespace AssetTool
{
    [JsonAsset("TestNameNetSerializer_TestObject")]
    public class UTestNameNetSerializer_TestObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestNameNetSerializer_TestObjectWithRPC")]
    public class UTestNameNetSerializer_TestObjectWithRPC : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}