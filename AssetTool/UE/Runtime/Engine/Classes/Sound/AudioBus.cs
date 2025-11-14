namespace AssetTool
{
    [JsonAsset("AudioBus")]
    public class UAudioBus : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}