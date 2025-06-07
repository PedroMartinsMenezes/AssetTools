namespace AssetTool
{
    [JsonAsset("TestMovieSceneTrack")]
    public class UTestMovieSceneTrack : UMovieSceneTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestMovieSceneSection")]
    public class UTestMovieSceneSection : UMovieSceneSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestMovieSceneSequence")]
    public class UTestMovieSceneSequence : UMovieSceneSequence
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestMovieSceneSubTrack")]
    public class UTestMovieSceneSubTrack : UMovieSceneSubTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestMovieSceneSubSection")]
    public class UTestMovieSceneSubSection : UMovieSceneSubSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestMovieSceneEvalHookTrack")]
    public class UTestMovieSceneEvalHookTrack : UMovieSceneTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestMovieSceneEvalHookSection")]
    public class UTestMovieSceneEvalHookSection : UMovieSceneHookSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}