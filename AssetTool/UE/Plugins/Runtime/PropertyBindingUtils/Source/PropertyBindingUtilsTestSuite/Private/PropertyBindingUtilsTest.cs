namespace AssetTool
{
    [JsonAsset("PropertyBindingUtilsTest_PropertyObjectInstanced")]
    public class UPropertyBindingUtilsTest_PropertyObjectInstanced : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PropertyBindingUtilsTest_PropertyObjectInstancedWithB")]
    public class UPropertyBindingUtilsTest_PropertyObjectInstancedWithB : UPropertyBindingUtilsTest_PropertyObjectInstanced
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PropertyBindingUtilsTest_PropertyObject")]
    public class UPropertyBindingUtilsTest_PropertyObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}