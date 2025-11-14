namespace AssetTool
{
    [JsonAsset("MoverExamplesGameMode")]
    public class AMoverExamplesGameMode : AGameMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}