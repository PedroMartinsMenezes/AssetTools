namespace AssetTool
{
    [JsonAsset("StateTreeTest_PropertyObjectInstanced")]
    public class UStateTreeTest_PropertyObjectInstanced : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StateTreeTest_PropertyObjectInstancedWithB")]
    public class UStateTreeTest_PropertyObjectInstancedWithB : UStateTreeTest_PropertyObjectInstanced
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StateTreeTest_PropertyObject")]
    public class UStateTreeTest_PropertyObject : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StateTreeTest_PropertyObject2")]
    public class UStateTreeTest_PropertyObject2 : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}