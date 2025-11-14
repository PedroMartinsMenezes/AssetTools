namespace AssetTool
{
    [JsonAsset("ARSharedWorldGameMode")]
    public class AARSharedWorldGameMode : AGameMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}