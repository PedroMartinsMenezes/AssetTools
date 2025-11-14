namespace AssetTool
{
    [JsonAsset("TestScriptInterfaceSubobject")]
    public class UTestScriptInterfaceSubobject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestScriptInterfaceReplicatedObject")]
    public class UTestScriptInterfaceReplicatedObject : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestScriptInterfaceReplicatedObjectWithDefaultSubobject")]
    public class UTestScriptInterfaceReplicatedObjectWithDefaultSubobject : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestObjectReferencingScriptInterface")]
    public class UTestObjectReferencingScriptInterface : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}