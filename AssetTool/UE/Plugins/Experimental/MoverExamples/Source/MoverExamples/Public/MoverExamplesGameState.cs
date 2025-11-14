namespace AssetTool
{
    [JsonAsset("MoverExamplesGameState")]
    public class AMoverExamplesGameState : AGameState
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}