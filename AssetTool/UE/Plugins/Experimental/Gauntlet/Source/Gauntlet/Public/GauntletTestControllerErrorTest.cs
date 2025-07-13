namespace AssetTool
{
    [JsonAsset("GauntletTestControllerErrorTest")]
    public class UGauntletTestControllerErrorTest : UGauntletTestController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}