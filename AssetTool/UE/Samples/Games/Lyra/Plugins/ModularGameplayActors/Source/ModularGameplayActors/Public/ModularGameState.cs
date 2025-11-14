namespace AssetTool
{
    [JsonAsset("ModularGameStateBase")]
    public class AModularGameStateBase : AGameStateBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModularGameState")]
    public class AModularGameState : AGameState
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}