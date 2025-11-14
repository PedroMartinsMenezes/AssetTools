namespace AssetTool
{
    [JsonAsset("ModularGameModeBase")]
    public class AModularGameModeBase : AGameModeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModularGameMode")]
    public class AModularGameMode : AGameMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}