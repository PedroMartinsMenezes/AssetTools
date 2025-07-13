namespace AssetTool
{
    [JsonAsset("SteamAuthComponentModuleInterface")]
    public class USteamAuthComponentModuleInterface : UHandlerComponentFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}