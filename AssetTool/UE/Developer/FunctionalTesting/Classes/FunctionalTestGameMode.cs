namespace AssetTool
{
    [JsonAsset("FunctionalTestGameMode")]
    public class AFunctionalTestGameMode : AGameModeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}