namespace AssetTool
{
    [JsonAsset("SoundModulatorBase")]
    public class USoundModulatorBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}