namespace AssetTool
{
    [JsonAsset("MoverExamplesGameState")]
    public class AMoverExamplesGameState : AGameState
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}