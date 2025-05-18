namespace AssetTool
{
    [JsonAsset("FunctionalTestGameMode")]
    public class AFunctionalTestGameMode : AGameModeBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}