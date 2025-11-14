namespace AssetTool
{
    [JsonAsset("TestPolymorphicStructNetSerializer_TestObject")]
    public class UTestPolymorphicStructNetSerializer_TestObject : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}