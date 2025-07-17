namespace AssetTool
{
    [JsonAsset("ModularGameModeBase")]
    public class AModularGameModeBase : AGameModeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModularGameMode")]
    public class AModularGameMode : AGameMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}