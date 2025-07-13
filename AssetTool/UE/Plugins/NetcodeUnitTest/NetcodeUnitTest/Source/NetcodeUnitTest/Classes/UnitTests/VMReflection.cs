namespace AssetTool
{
    [JsonAsset("VMReflection")]
    public class UVMReflection : UUnitTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VMTestClassA")]
    public class UVMTestClassA : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VMTestClassB")]
    public class UVMTestClassB : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}