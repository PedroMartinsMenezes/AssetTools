namespace AssetTool
{
    [JsonAsset("MoverExamplesGameState")]
    public class AMoverExamplesGameState : AGameState
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}