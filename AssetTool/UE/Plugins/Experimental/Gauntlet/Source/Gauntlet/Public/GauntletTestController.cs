namespace AssetTool
{
    [JsonAsset("GauntletTestController")]
    public class UGauntletTestController : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}