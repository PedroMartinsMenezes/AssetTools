namespace AssetTool
{
    [JsonAsset("MovieSceneNodeGroup")]
    public class UMovieSceneNodeGroup : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieSceneNodeGroupCollection")]
    public class UMovieSceneNodeGroupCollection : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieScene")]
    public class UMovieScene : UMovieSceneSignedObject
    {
        public UMovieScene()
        {
            MapMovers.Add("ObjectsToDisplayNames", ((transfer1, value1) => value1.ToObject<FString>(transfer1).Move(transfer1), (transfer2, value2) => value2.ToObject<FText>(transfer2).Move(transfer2)));
            MapMovers.Add("ExpansionStates", ((transfer1, value1) => value1.ToObject<FString>(transfer1).Move(transfer1), (transfer2, value2) => null));
        }

        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}