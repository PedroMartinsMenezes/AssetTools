namespace AssetTool
{
    [JsonAsset("TestPolymorphicStructNetSerializer_TestObject")]
    public class UTestPolymorphicStructNetSerializer_TestObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}