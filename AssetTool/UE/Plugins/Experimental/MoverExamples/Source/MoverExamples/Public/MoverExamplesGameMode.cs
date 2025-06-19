namespace AssetTool
{
    [JsonAsset("MoverExamplesGameMode")]
    public class AMoverExamplesGameMode : AGameMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}