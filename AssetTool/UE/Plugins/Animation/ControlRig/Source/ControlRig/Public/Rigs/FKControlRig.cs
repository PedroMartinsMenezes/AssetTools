namespace AssetTool
{
    [JsonAsset("FKControlRig")]
    public class UFKControlRig : UControlRig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}