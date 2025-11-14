namespace AssetTool
{
    [JsonAsset("ICVFXTestControllerBase")]
    public class UICVFXTestControllerBase : UGauntletTestController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}