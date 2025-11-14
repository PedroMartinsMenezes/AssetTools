namespace AssetTool
{
    [JsonAsset("SoundModulatorBase")]
    public class USoundModulatorBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}