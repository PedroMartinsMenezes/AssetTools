namespace AssetTool
{
    [JsonAsset("TP_SIM_BlankGameModeBase")]
    public class ATP_SIM_BlankGameModeBase : AGameModeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}