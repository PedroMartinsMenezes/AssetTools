namespace AssetTool
{
    [JsonAsset("TestReflectionObject")]
    public class UTestReflectionObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}