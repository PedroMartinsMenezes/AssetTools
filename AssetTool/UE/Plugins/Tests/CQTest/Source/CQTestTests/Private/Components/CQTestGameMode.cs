namespace AssetTool
{
    [JsonAsset("CQTestGameMode")]
    public class ACQTestGameMode : AGameModeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}