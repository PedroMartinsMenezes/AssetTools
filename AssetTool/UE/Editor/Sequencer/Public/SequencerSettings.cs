namespace AssetTool
{
    [JsonAsset("SequencerSettingsContainer")]
    public class USequencerSettingsContainer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SequencerSettings")]
    public class USequencerSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}