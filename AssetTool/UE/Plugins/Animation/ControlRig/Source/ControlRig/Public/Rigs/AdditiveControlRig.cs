namespace AssetTool
{
    [JsonAsset("AdditiveControlRig")]
    public class UAdditiveControlRig : UControlRig
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}