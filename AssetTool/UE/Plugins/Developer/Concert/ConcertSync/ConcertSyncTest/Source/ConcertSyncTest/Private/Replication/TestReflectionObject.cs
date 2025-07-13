namespace AssetTool
{
    [JsonAsset("TestReflectionObject")]
    public class UTestReflectionObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}