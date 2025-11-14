namespace AssetTool
{
    [JsonAsset("ControlRigTestData")]
    public class UControlRigTestData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}