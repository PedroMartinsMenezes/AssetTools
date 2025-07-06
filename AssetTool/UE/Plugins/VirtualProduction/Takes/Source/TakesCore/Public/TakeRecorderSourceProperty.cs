namespace AssetTool
{
    [JsonAsset("ActorRecorderPropertyMap")]
    public class UActorRecorderPropertyMap : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TakeRecorderAudioInputSettings")]
    public class UTakeRecorderAudioInputSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}