namespace AssetTool
{
    [JsonAsset("TestInstanceDataObjectClass")]
    public class UTestInstanceDataObjectClass : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}