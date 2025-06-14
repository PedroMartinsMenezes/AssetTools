namespace AssetTool
{
    [JsonAsset("MoverExamplesGameMode")]
    public class AMoverExamplesGameMode : AGameMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}