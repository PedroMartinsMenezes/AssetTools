namespace AssetTool
{
    [JsonAsset("TakeRecorderMicrophoneAudioManager")]
    public class UTakeRecorderMicrophoneAudioManager : UTakeRecorderAudioInputSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}