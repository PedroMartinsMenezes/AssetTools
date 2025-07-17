namespace AssetTool
{
    [JsonAsset("ModularGameStateBase")]
    public class AModularGameStateBase : AGameStateBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModularGameState")]
    public class AModularGameState : AGameState
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}