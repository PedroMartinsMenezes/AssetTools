namespace AssetTool
{
    [JsonAsset("ICVFXTestControllerBase")]
    public class UICVFXTestControllerBase : UGauntletTestController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}