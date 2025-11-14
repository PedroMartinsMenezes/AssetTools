namespace AssetTool
{
    [JsonAsset("ARSharedWorldGameState")]
    public class AARSharedWorldGameState : AGameState
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}