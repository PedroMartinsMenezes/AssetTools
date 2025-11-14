namespace AssetTool
{
    [JsonAsset("TakeRecorderMicrophoneAudioManager")]
    public class UTakeRecorderMicrophoneAudioManager : UTakeRecorderAudioInputSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}