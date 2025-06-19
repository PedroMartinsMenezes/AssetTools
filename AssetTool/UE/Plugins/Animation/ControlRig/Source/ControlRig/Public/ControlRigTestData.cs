namespace AssetTool
{
    [JsonAsset("ControlRigTestData")]
    public class UControlRigTestData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}