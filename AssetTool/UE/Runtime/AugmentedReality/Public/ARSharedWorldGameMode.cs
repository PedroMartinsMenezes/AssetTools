namespace AssetTool
{
    [JsonAsset("ARSharedWorldGameMode")]
    public class AARSharedWorldGameMode : AGameMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}