namespace AssetTool
{
    [JsonAsset("MovieSceneGameplayCueTriggerSection")]
    public class UMovieSceneGameplayCueTriggerSection : UMovieSceneHookSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneGameplayCueSection")]
    public class UMovieSceneGameplayCueSection : UMovieSceneHookSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}