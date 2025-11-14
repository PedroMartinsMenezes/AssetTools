namespace AssetTool
{
    [JsonAsset("GauntletTestControllerErrorTest")]
    public class UGauntletTestControllerErrorTest : UGauntletTestController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}