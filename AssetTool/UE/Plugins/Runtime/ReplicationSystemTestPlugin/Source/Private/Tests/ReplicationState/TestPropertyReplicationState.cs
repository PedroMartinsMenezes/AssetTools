namespace AssetTool
{
    [JsonAsset("TestPropertyReplicationState_TestClass")]
    public class UTestPropertyReplicationState_TestClass : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestPropertyReplicationState_TestClassWithRepNotify")]
    public class UTestPropertyReplicationState_TestClassWithRepNotify : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestPropertyReplicationState_TestClassWithInitAndCArrays")]
    public class UTestPropertyReplicationState_TestClassWithInitAndCArrays : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestPropertyReplicationState_TestClassWithTArray")]
    public class UTestPropertyReplicationState_TestClassWithTArray : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestPropertyReplicationState_NoRegisterFragments")]
    public class UTestPropertyReplicationState_NoRegisterFragments : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}