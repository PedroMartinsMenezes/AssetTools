namespace AssetTool
{
    [JsonAsset("TestNameNetSerializer_TestObject")]
    public class UTestNameNetSerializer_TestObject : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestNameNetSerializer_TestObjectWithRPC")]
    public class UTestNameNetSerializer_TestObjectWithRPC : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}