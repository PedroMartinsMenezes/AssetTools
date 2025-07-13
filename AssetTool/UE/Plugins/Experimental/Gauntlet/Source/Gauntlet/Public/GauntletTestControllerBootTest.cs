namespace AssetTool
{
    [JsonAsset("GauntletTestControllerBootTest")]
    public class UGauntletTestControllerBootTest : UGauntletTestController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}