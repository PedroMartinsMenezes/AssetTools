namespace AssetTool
{
    [JsonAsset("SimpleClassForFieldPathNetSerializerTest")]
    public class USimpleClassForFieldPathNetSerializerTest : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InheritedSimpleClassForFieldPathNetSerializerTest")]
    public class UInheritedSimpleClassForFieldPathNetSerializerTest : USimpleClassForFieldPathNetSerializerTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}