namespace AssetTool
{
    [JsonAsset("FKControlRig")]
    public class  UFKControlRig : UControlRig
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}