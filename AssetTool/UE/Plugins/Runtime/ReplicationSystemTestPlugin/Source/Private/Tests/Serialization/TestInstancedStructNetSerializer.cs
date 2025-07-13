namespace AssetTool
{
    [JsonAsset("InstancedStructNetSerializerTestObject")]
    public class UInstancedStructNetSerializerTestObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}