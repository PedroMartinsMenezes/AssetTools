namespace AssetTool
{
    [JsonAsset("TestInstanceDataObjectClass")]
    public class UTestInstanceDataObjectClass : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}