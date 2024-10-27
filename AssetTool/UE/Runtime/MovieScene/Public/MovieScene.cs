namespace AssetTool
{
    [JsonAsset("MovieSceneNodeGroup")]
    public class  UMovieSceneNodeGroup : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneNodeGroupCollection")]
    public class  UMovieSceneNodeGroupCollection : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieScene")]
    public class  UMovieScene : UMovieSceneSignedObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}