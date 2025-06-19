namespace AssetTool
{
    [JsonAsset("AdditiveControlRig")]
    public class UAdditiveControlRig : UControlRig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}