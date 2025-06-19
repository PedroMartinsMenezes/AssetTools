namespace AssetTool
{
    [JsonAsset("FKControlRig")]
    public class UFKControlRig : UControlRig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}