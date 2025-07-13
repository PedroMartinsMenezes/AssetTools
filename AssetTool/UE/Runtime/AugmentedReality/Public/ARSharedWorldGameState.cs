namespace AssetTool
{
    [JsonAsset("ARSharedWorldGameState")]
    public class AARSharedWorldGameState : AGameState
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}