namespace AssetTool
{
    [JsonAsset("InstancedStructNetSerializerTestObject")]
    public class UInstancedStructNetSerializerTestObject : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}