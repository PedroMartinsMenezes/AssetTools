namespace AssetTool
{
    [JsonAsset("GauntletTestControllerBootTest")]
    public class UGauntletTestControllerBootTest : UGauntletTestController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}