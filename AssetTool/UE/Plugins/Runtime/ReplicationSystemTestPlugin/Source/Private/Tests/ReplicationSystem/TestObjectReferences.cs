namespace AssetTool
{
    [JsonAsset("TestObjectReferences_TestClassWithReferences")]
    public class UTestObjectReferences_TestClassWithReferences : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestObjectReferences_TestClassWithDefaultSubObject")]
    public class UTestObjectReferences_TestClassWithDefaultSubObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}