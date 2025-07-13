namespace AssetTool
{
    [JsonAsset("TestFastArrayReplicationState_FastArray_TestClassFastArray")]
    public class UTestFastArrayReplicationState_FastArray_TestClassFastArray : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestFastArrayReplicationState_FastArray_TestClassFastArrayWithExtraProperty")]
    public class UTestFastArrayReplicationState_FastArray_TestClassFastArrayWithExtraProperty : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}