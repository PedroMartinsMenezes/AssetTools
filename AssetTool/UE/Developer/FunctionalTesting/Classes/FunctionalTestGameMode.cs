namespace AssetTool
{
    [JsonAsset("FunctionalTestGameMode")]
    public class AFunctionalTestGameMode : AGameModeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}