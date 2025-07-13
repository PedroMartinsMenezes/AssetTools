namespace AssetTool
{
    [JsonAsset("TestPrioritizationNativeIrisObject")]
    public class UTestPrioritizationNativeIrisObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestPrioritizationObject")]
    public class UTestPrioritizationObject : UReplicatedTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestPrioritizationWithWorldLocationObject")]
    public class UTestPrioritizationWithWorldLocationObject : UTestPrioritizationObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}