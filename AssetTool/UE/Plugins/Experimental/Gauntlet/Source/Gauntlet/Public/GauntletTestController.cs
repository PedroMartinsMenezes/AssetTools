namespace AssetTool
{
    [JsonAsset("GauntletTestController")]
    public class UGauntletTestController : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}