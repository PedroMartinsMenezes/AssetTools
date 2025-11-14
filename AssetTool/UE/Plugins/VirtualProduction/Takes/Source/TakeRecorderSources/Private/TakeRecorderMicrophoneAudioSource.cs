namespace AssetTool
{
    [JsonAsset("TakeRecorderMicrophoneAudioSourceSettings")]
    public class UTakeRecorderMicrophoneAudioSourceSettings : UTakeRecorderSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TakeRecorderMicrophoneAudioSource")]
    public class UTakeRecorderMicrophoneAudioSource : UTakeRecorderMicrophoneAudioSourceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}