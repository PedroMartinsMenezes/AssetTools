namespace AssetTool
{
    [JsonAsset("AdditiveControlRig")]
    public class UAdditiveControlRig : UControlRig
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}