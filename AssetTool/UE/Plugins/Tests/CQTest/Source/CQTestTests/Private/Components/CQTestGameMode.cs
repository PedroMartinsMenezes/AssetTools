namespace AssetTool
{
    [JsonAsset("CQTestGameMode")]
    public class ACQTestGameMode : AGameModeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}